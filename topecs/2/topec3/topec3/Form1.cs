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
namespace topec3
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









                MyGrammerVisitor visitor = new MyGrammerVisitor();
                Dictionary<string, string> variables = visitor.Visit(tree);

                textBox2.Text = "";
                foreach (var variable in variables)
                {
                    textBox2.AppendText("\n Variable: " + variable.Key.ToString() + " Value : " + variable.Value.ToString());
                }

                    
                
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }




    public class MyGrammerVisitor : MyGrammerBaseVisitor<Dictionary<string, string>>
    {
        public override Dictionary<string, string> VisitProg(MyGrammerParser.ProgContext context)
        {
            return Visit(context.statement());
        }

        public override Dictionary<string, string> VisitStatement(MyGrammerParser.StatementContext context)
        {
            Dictionary<string, string> variables = new Dictionary<string, string>();

            // أول تعريف
            Dictionary<string, string> firstDeclVariables = Visit(context.firstDecl());


            foreach (var variable in firstDeclVariables)
            {
                variables[variable.Key] = variable.Value;
            }

            // تعريفات إضافية (إن وجدت)
            foreach (var decl in context.decler2())
            {
                Dictionary<string, string> declVariables = Visit(decl);
                foreach (var variable in declVariables)
                {
                    variables[variable.Key] = variable.Value;
                }
            }

            return variables;
        }

        public override Dictionary<string, string> VisitFirstDecl(MyGrammerParser.FirstDeclContext context)
        {
            Dictionary<string, string> variables = new Dictionary<string, string>();

            string varName = context.ID().GetText();


            if (context.NUMBER() != null)
            {
                string value = context.NUMBER().GetText();
                variables[varName] = value;
            }
            else
            {
                variables[varName] = "No value assigned";
            }

            return variables;
        }

        public override Dictionary<string, string> VisitDecler2(MyGrammerParser.Decler2Context context)
        {
            Dictionary<string, string> variables = new Dictionary<string, string>();

            string varName = context.ID().GetText();
            if (context.NUMBER() != null)
            {
                string value = context.NUMBER().GetText();
                variables[varName] = value; // تخزين المتغير مع القيمة
            }
            else
            {
                variables[varName] = "No value assigned"; // المتغير بدون قيمة مسندة
            }

            return variables;
        }
    }






}

