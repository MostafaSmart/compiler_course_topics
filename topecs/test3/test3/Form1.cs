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

namespace test3
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


                parser.RemoveErrorListeners();
                parser.AddErrorListener(new MyErrorLis(textBox2));

                parser.BuildParseTree = true;
                IParseTree tree = parser.prog();

                MyGrammerVisitor visitor = new MyGrammerVisitor();
                int result = visitor.Visit(tree);

            
                MessageBox.Show("النتيجة: " + result.ToString());


                //textBox3.Text = tree.ToStringTree(parser);


            }
        
        }
    }



    public class MyErrorLis : BaseErrorListener
    {

        TextBox _textBox;

        public MyErrorLis(TextBox textBox)
        {
            _textBox = textBox;

        }
        public override void SyntaxError(IRecognizer recognizer, IToken offendingSymbol, int line, int charPositionInLine, string msg, RecognitionException e)
        {

            _textBox.AppendText("massege : (" + msg + ") line: (" + line + ") collumn: (" + charPositionInLine + ")\n");
        }

    }



    public class MyGrammerVisitor : MyGrammerBaseVisitor<int>
    {
        public override int VisitProg(MyGrammerParser.ProgContext context)
        {
            
            return Visit(context.expr());
        }

        public override int VisitExpr(MyGrammerParser.ExprContext context)
        {
            if (context.term() != null && context.expr() == null)
            {
                // إذا كانت term فقط
                return Visit(context.term());
            }
            else if (context.expr() != null && context.PLUS() != null)
            {
                // إذا كانت expr PLUS term
                return Visit(context.expr()) + Visit(context.term());
            }
            else if (context.expr() != null && context.MINUS() != null)
            {
                // إذا كانت expr MINUS term
                return Visit(context.expr()) - Visit(context.term());
            }

            return 0;
        }

        public override int VisitTerm(MyGrammerParser.TermContext context)
        {
            if (context.factor() != null && context.term() == null)
            {
                // إذا كانت factor فقط
                return Visit(context.factor());
            }
            else if (context.term() != null && context.MUL() != null)
            {
                // إذا كانت term MUL factor
                return Visit(context.term()) * Visit(context.factor());
            }
            else if (context.term() != null && context.DIV() != null)
            {
                // إذا كانت term DIV factor
                return Visit(context.term()) / Visit(context.factor());
            }

            return 0;
        }

        public override int VisitFactor(MyGrammerParser.FactorContext context)
        {
            if (context.NUMBERS() != null)
            {
                // إذا كانت NUMBERS
                return int.Parse(context.NUMBERS().GetText());
            }
            else if (context.LIFT() != null && context.expr() != null && context.RIGHT() != null)
            {
                // إذا كان لدينا تعبير محاط بالأقواس
                return Visit(context.expr());
            }

            return 0;
        }
    }


}
