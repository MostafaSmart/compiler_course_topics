using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
namespace _5_1
{

    using System.IO;
using System.Text;

class MyGrammerVisitor : MyGrammerBaseVisitor<string>
{
    private Dictionary<string, int?> variables = new Dictionary<string, int?>();

    // تخزين الكود المولد
    private StringBuilder generatedCode = new StringBuilder();

    public void SaveCodeToFile(string filePath)
    {
        File.WriteAllText(filePath, generatedCode.ToString());
    }

    public override string VisitProgram(MyGrammerParser.ProgramContext context)
    {
       
        generatedCode.AppendLine("#include <iostream>");
        generatedCode.AppendLine("#include <cstdlib>");

        generatedCode.AppendLine("using namespace std;");
        generatedCode.AppendLine("int main() {");

    
        foreach (var stmt in context.statement())
        {
            Visit(stmt);
        }

        generatedCode.AppendLine("     system(\"pause\");");


        generatedCode.AppendLine("    return 0;");
        generatedCode.AppendLine("}");

        return null;
    }

    public override string VisitVariableDeclaration(MyGrammerParser.VariableDeclarationContext context)
    {
        foreach (var variable in context.variable())
        {
            string varName = variable.IDENTIFIER().GetText();
            string declaration;

            if (variable.expr() != null)
            {
                string exprCode = Visit(variable.expr());
                declaration = "int " + varName + " = " +exprCode + " ;";
            }
            else
            {
                declaration = "int " +varName +";";
            }

          
            generatedCode.AppendLine("    " + declaration);
        }

        return null;
    }

    public override string VisitExpr(MyGrammerParser.ExprContext context)
    {
        if (context.PLUS() != null)
        {
            return Visit(context.expr()) + " + " + Visit(context.term());
        }
        else if (context.MINUS() != null)
        {
            return Visit(context.expr()) + " - " + Visit(context.term());
        }

        return Visit(context.term());
    }

    public override string VisitTerm(MyGrammerParser.TermContext context)
    {
        if (context.MUL() != null)
        {
            return Visit(context.term()) + " * " + Visit(context.factor());
        }
        else if (context.DIV() != null)
        {
            return Visit(context.term()) + " / " + Visit(context.factor());
        }

        return Visit(context.factor());
    }

    public override string VisitFactor(MyGrammerParser.FactorContext context)
    {
        if (context.NUMBER() != null)
        {
            return context.NUMBER().GetText();
        }
        else if (context.LIFT() != null)
        {
            return "(" + Visit(context.expr()) + ")";
        }
        else if (context.IDENTIFIER() != null)
        {
            return context.IDENTIFIER().GetText();
        }

        throw new Exception("Invalid factor encountered");
    }

    public override string VisitIfStatement(MyGrammerParser.IfStatementContext context)
    {
        string condition = Visit(context.comparisonExpression());

        generatedCode.AppendLine("    if (" + condition + ") {");
        Visit(context.block());
        generatedCode.AppendLine("    }");

        if (context.elseStat() != null)
        {
            generatedCode.AppendLine("    else {");
            Visit(context.elseStat());
            generatedCode.AppendLine("    }");
        }

        return null;
    }

    public override string VisitElseStat(MyGrammerParser.ElseStatContext context)
    {
        Visit(context.block());
        return null;
    }

    public override string VisitComparisonExpression(MyGrammerParser.ComparisonExpressionContext context)
    {
        string left = Visit(context.expr(0));
        string right = Visit(context.expr(1));

        if (context.LT() != null)
        {
            return left + " < " + right;
        }
        else if (context.GT() != null)
        {
            return left + " > " + right;
        }
        else if (context.AQU() != null)
        {
            return left + " == " + right;
        }
        else if (context.NOTAQU() != null)
        {
            return left + " != " + right;
        }

        return "";
    }

    public override string VisitBlock(MyGrammerParser.BlockContext context)
    {
        foreach (var stmt in context.statement())
        {
            Visit(stmt);
        }

        return null;
    }

    public override string VisitPrintStatement(MyGrammerParser.PrintStatementContext context)
    {
        string expr = Visit(context.expr());
        generatedCode.AppendLine("    cout << " + expr + " << endl;");
        return null;
    }
}


    //class MyGrammerVisitor : MyGrammerBaseVisitor<int?>
    //{

    //    private Dictionary<string, int?> variables = new Dictionary<string, int?>();


    //    RichTextBox richTextBox;

    //    public MyGrammerVisitor(RichTextBox text)
    //    {

    //        richTextBox = text;
    //    }

    //    public Dictionary<string, int?> GetVariables()
    //    {
    //        return variables;
    //    }

     



    //    public override int? VisitVariableDeclaration(MyGrammerParser.VariableDeclarationContext context)
    //    {
    //        foreach (var variable in context.variable())
    //        {
    //            string varName = variable.IDENTIFIER().GetText();

    //            // نتحقق اذا المتغير معرف مسبقا او لا 
    //            if (variables.ContainsKey(varName))
    //            {
    //                throw new Exception("Error: Variable  " + varName + " is already defined.");
    //            }

    //            // إذا كان في عملية حسابية  ننفذها
    //            if (variable.expr() != null)
    //            {
    //                int value = (int)Visit(variable.expr());
    //                variables[varName] = value;
    //            }
    //            else
    //            {

    //                variables[varName] = null;
    //            }
    //        }

    //        return null;
    //    }

    //    public override int? VisitExpr(MyGrammerParser.ExprContext context)
    //    {
    //        if (context.PLUS() != null)
    //        {
    //            return (int)Visit(context.expr()) + (int)Visit(context.term());
    //        }
    //        else if (context.MINUS() != null)
    //        {
    //            return (int)Visit(context.expr()) - (int)Visit(context.term());

    //        }

    //        return Visit(context.term());
    //    }

    //    public override int? VisitTerm(MyGrammerParser.TermContext context)
    //    {
    //        if (context.MUL() != null)
    //        {
    //            return (int)Visit(context.term()) * (int)Visit(context.factor());
    //        }
    //        else if (context.DIV() != null)
    //        {
    //            return (int)Visit(context.term()) / (int)Visit(context.factor());
    //        }

    //        return Visit(context.factor());
    //    }

    //    public override int? VisitFactor(MyGrammerParser.FactorContext context)
    //    {
    //        if (context.NUMBER() != null)
    //        {
    //            return int.Parse(context.NUMBER().GetText());
    //        }
    //        else if (context.LIFT() != null)
    //        {
    //            return Visit(context.expr());
    //        }
    //        else if (context.IDENTIFIER() != null)
    //        {
    //            string varName = context.IDENTIFIER().GetText();

    //            if (variables.ContainsKey(varName))
    //            {
    //                if (variables[varName] != null)
    //                {
    //                    return variables[varName];
    //                }
    //                else
    //                {
    //                    throw new Exception("Error: Variable " + varName + " value is null.");
    //                }
    //            }
    //            else
    //            {
    //                throw new Exception("Error: Variable " + varName + " is not defined yet.");
    //            }
    //        }

    //        throw new Exception("Invalid factor encountered");
    //    }




    //    public override int? VisitIfStatement(MyGrammerParser.IfStatementContext context)
    //    {
    //        int condition = (int)Visit(context.comparisonExpression());

    //        if (condition == 1)
    //        {
    //            // تنفيذ block إذا كان الشرط صحيح
    //            Visit(context.block());
    //        }
    //        else if (context.elseStat() != null)
    //        {


    //            Visit(context.elseStat());
    //        }

    //        return null;
    //    }



    //    public override int? VisitElseStat(MyGrammerParser.ElseStatContext context)
    //    {

    //        Visit(context.block());

    //        return null;

    //    }


    //    public override int? VisitComparisonExpression(MyGrammerParser.ComparisonExpressionContext context)
    //    {
    //        int left = (int)Visit(context.expr(0));
    //        int right = (int)Visit(context.expr(1));

    //        // تنفيذ عمليات المقارنة
    //        if (context.LT() != null)
    //        {
    //            return (left < right) ? 1 : 0;
    //        }
    //        else if (context.GT() != null)
    //        {
    //            return (left > right) ? 1 : 0;
    //        }
    //        else if (context.AQU() != null)
    //        {
    //            return (left == right) ? 1 : 0;
    //        }
    //        else if (context.NOTAQU() != null)
    //        {

    //            return (left != right) ? 1 : 0;
    //        }

    //        return 0;
    //    }


    //    public override int? VisitBlock(MyGrammerParser.BlockContext context)
    //    {
    //        foreach (var stmt in context.statement())
    //        {
    //            Visit(stmt);
    //        }

    //        return null;
    //    }


    //    public override int? VisitPrintStatement(MyGrammerParser.PrintStatementContext context)
    //    {

            

    //        int left = (int)Visit(context.expr());

    //        //_text.AppendText(left.ToString() + '\n');

    //        return null;
    //    }





    //}





}
