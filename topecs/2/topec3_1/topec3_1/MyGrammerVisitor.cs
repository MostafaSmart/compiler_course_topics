using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
namespace topec3_1
{
    class MyGrammerVisitor : MyGrammerBaseVisitor<int?>
    {
        
        private Dictionary<string, int?> variables = new Dictionary<string, int?>();


        public Dictionary<string, int?> GetVariables()
        {
            return variables;
        }


        public override int? VisitFirstDecl(MyGrammerParser.FirstDeclContext context)
        {
            string varName = context.ID().GetText();
            int? value = null;

            if (variables.ContainsKey(varName))
            {

                throw new Exception("Error: Variable "+ varName + " is already defined.");

            }

            if (context.expr() != null)
            {
                value = Visit(context.expr());
            }


            variables[varName] = value;

            return null;
        }


        public override int? VisitDecler2(MyGrammerParser.Decler2Context context)
        {
            string varName = context.ID().GetText();
            int? value = null;

              if (variables.ContainsKey(varName))
            {

                throw new Exception("Error: Variable "+ varName + " is already defined.");

            }

            if (context.expr() != null)
            {
                value = Visit(context.expr());
            }


            variables[varName] = value;

            return null;
        }


        public override int? VisitExpr(MyGrammerParser.ExprContext context)
        {
            if (context.PLUS() != null)
            {
                return Visit(context.expr()) + Visit(context.term());
            }
            else if (context.MINUS() != null)
            {
                return Visit(context.expr()) - Visit(context.term());
            }

            return Visit(context.term());
        }


        public override int? VisitTerm(MyGrammerParser.TermContext context)
        {
            if (context.MUL() != null)
            {
                return Visit(context.term()) * Visit(context.factor());
            }
            else if (context.DIV() != null)
            {
                return Visit(context.term()) / Visit(context.factor());
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

            else if (context.ID() != null)
            {
                string varName = context.ID().GetText();

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
                else {

                    throw new Exception("Error: Variable " + varName + " is not defined yet.");
                
                }

            }

            throw new Exception("Invalid factor encountered");
        }
    }
    }

