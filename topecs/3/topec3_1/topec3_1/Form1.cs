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


namespace topec3_1
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
                IParseTree tree = parser.prog();

                MyGrammarVisitor visitor = new MyGrammarVisitor();
                visitor.Visit(tree);

                // Get the stored variables and their values
                var variables = visitor.GetVariables();

                // Display the variables in the output (e.g., in textBox2)
                foreach (var variable in variables)
                {
                    textBox2.AppendText(" Var:  " + variable.Key.ToString() + "  Type  :  " + variable.Value.Type.ToString() + "  Value :  " + variable.Value.Value.ToString() + " \n");
                }



            }
        }
    }






    public class MyGrammerVisitorImpl : MyGrammerBaseVisitor<int?>
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

            throw new Exception("Invalid factor encountered");
        }
    }
}


