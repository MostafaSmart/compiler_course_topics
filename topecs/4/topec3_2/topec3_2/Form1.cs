﻿using System;
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

namespace topec3_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                string input = textBox1.Text.ToString();

                AntlrInputStream inputStreem = new AntlrInputStream(input);

                MyGrammerLexer lexer = new MyGrammerLexer(inputStreem);


                CommonTokenStream lTS = new CommonTokenStream(lexer);

                MyGrammerParser parser = new MyGrammerParser(lTS);

                textBox2.Clear();
                parser.RemoveErrorListeners();

                parser.AddErrorListener(new MyErrorListener(textBox2));


                parser.BuildParseTree = true;
                IParseTree tree = parser.program();
                MyGrammerVisitor visitor = new MyGrammerVisitor(textBox2);
                visitor.Visit(tree);


            }
        }



 

    }


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

        // Visit program and handle the overall execution
        public override int? VisitProgram(MyGrammerParser.ProgramContext context)
        {
            Visit(context.declarlist());
            Visit(context.ifStatement());
            return null;
        }

        public override int? VisitDeclar(MyGrammerParser.DeclarContext context)
        {
            string varName = context.ID().GetText();
            int? value = null;

            if (variables.ContainsKey(varName))
            {
                throw new Exception("Error: Variable " + varName + " is already defined.");
            }

            if (context.expr() != null)
            {
                value = Visit(context.expr());
            }

            variables[varName] = value;
            return null;
        }

        public override int? VisitDeclar2(MyGrammerParser.Declar2Context context)
        {
            string varName = context.ID().GetText();
            int? value = null;

            if (variables.ContainsKey(varName))
            {
                throw new Exception("Error: Variable " + varName + " is already defined.");
            }

            if (context.expr() != null)
            {
                value = Visit(context.expr());
            }

            variables[varName] = value;
            return null;
        }

        public override int? VisitIfStatement(MyGrammerParser.IfStatementContext context)
        {
            // Evaluate the condition
            if (Visit(context.condition()) == 1) // Assuming 1 represents 'true'
            {
                Visit(context.statements());
            }
            return null;
        }

        public override int? VisitCondition(MyGrammerParser.ConditionContext context)
        {
            int? left = Visit(context.expr(0));
            int? right = Visit(context.expr(1));

            if (context.GT() != null)
            {
                return left > right ? 1 : 0; // Return 1 for true, 0 for false
            }
            else if (context.LT() != null)
            {
                return left < right ? 1 : 0;
            }

            return 0; // Default case
        }

        public override int? VisitStatements(MyGrammerParser.StatementsContext context)
        {
            return Visit(context.prints());
        }

        public override int? VisitPrints(MyGrammerParser.PrintsContext context)
        {
            int? valueToPrint = Visit(context.expr());
            _text.AppendText(valueToPrint.ToString()); // Print the value to the console
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
                else
                {
                    throw new Exception("Error: Variable " + varName + " is not defined yet.");
                }
            }

            throw new Exception("Invalid factor encountered");
        }
    }


    public class MyErrorListener : BaseErrorListener
    {

        TextBox errorTextBox;

        public MyErrorListener(TextBox _textBox)
        {
            errorTextBox = _textBox;

        }

        public override void SyntaxError(IRecognizer recognizer, IToken offendingSymbol, int line, int charPositionInLine, string msg, RecognitionException e)
        {


            errorTextBox.AppendText(msg + " line : " + line + " possotisn : " + charPositionInLine + " \n");


        }



    }
}
