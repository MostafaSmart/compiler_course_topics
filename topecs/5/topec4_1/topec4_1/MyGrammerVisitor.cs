using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
namespace topec4_1
{

    class MyGrammerVisitor : MyGrammerBaseVisitor<int?>
    {

        private Dictionary<string, int?> variables = new Dictionary<string, int?>();


        TextBox _text;

        public MyGrammerVisitor(TextBox text)
        {

            _text = text;
        }

        public Dictionary<string, int?> GetVariables()
        {
            return variables;
        }


        public override int? VisitVariableDeclaration(MyGrammerParser.VariableDeclarationContext context)
        {
            foreach (var variable in context.variable())
            {
                string varName = variable.IDENTIFIER().GetText();

                // نتحقق اذا المتغير معرف مسبقا او لا 
                if (variables.ContainsKey(varName))
                {
                    throw new Exception("Error: Variable  " + varName + " is already defined.");
                }

                // إذا كان في عملية حسابية  ننفذها
                if (variable.expr() != null)
                {
                    int value = (int)Visit(variable.expr());
                    variables[varName] = value;
                }
                else
                {

                    variables[varName] = null;
                }
            }

            return null;
        }

        public override int? VisitExpr(MyGrammerParser.ExprContext context)
        {
            if (context.PLUS() != null)
            {
                return (int)Visit(context.expr()) + (int)Visit(context.term());
            }
            else if (context.MINUS() != null)
            {
                return (int)Visit(context.expr()) - (int)Visit(context.term());

            }

            return Visit(context.term());
        }

        public override int? VisitTerm(MyGrammerParser.TermContext context)
        {
            if (context.MUL() != null)
            {
                return (int)Visit(context.term()) * (int)Visit(context.factor());
            }
            else if (context.DIV() != null)
            {
                return (int)Visit(context.term()) / (int)Visit(context.factor());
            }

            return Visit(context.factor());
        }

        public override int? VisitFactor(MyGrammerParser.FactorContext context)
        {
            if (context.NUMBER() != null)
            {
                return int.Parse(context.NUMBER().GetText());
            }
            else if (context.LIFT() != null)
            {
                return Visit(context.expr());
            }
            else if (context.IDENTIFIER() != null)
            {
                string varName = context.IDENTIFIER().GetText();

                if (variables.ContainsKey(varName))
                {
                    if (variables[varName] != null)
                    {
                        return variables[varName];
                    }
                    else
                    {
                        throw new Exception("Error: Variable " + varName + " value is null.");
                    }
                }
                else
                {
                    throw new Exception("Error: Variable " + varName + " is not defined yet.");
                }
            }

            throw new Exception("Invalid factor encountered");
        }




        public override int? VisitIfStatement(MyGrammerParser.IfStatementContext context)
        {
            int condition = (int)Visit(context.comparisonExpression());

            if (condition == 1)
            {
                // تنفيذ block إذا كان الشرط صحيح
                Visit(context.block());
            }
            else if (context.elseStat() != null)
            {


                Visit(context.elseStat());
            }

            return null;
        }



        public override int? VisitElseStat(MyGrammerParser.ElseStatContext context)
        {

            Visit(context.block());

            return null;

        }


        public override int? VisitComparisonExpression(MyGrammerParser.ComparisonExpressionContext context)
        {
            int left = (int)Visit(context.expr(0));
            int right = (int)Visit(context.expr(1));

            // تنفيذ عمليات المقارنة
            if (context.LT() != null)
            {
                return (left < right) ? 1 : 0;
            }
            else if (context.GT() != null)
            {
                return (left > right) ? 1 : 0;
            }
            else if (context.AQU() != null)
            {
                return (left == right) ? 1 : 0;
            }
            else if (context.NOTAQU() != null)
            {

                return (left != right) ? 1 : 0;
            }

            return 0;
        }


        public override int? VisitBlock(MyGrammerParser.BlockContext context)
        {
            foreach (var stmt in context.statement())
            {
                Visit(stmt);
            }

            return null;
        }


        public override int? VisitPrintStatement(MyGrammerParser.PrintStatementContext context)
        {


            int left = (int)Visit(context.expr());

            _text.AppendText(left.ToString() + '\n');

            return null;
        }




    }


}
