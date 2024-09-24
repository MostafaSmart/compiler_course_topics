using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using System.Windows.Forms;
namespace topec3
{

    public class MyErrorListener : BaseErrorListener
    {

        TextBox errorTextBox;

        public MyErrorListener(TextBox _textBox)
        {
            errorTextBox = _textBox;

        }

        public override void SyntaxError(IRecognizer recognizer, IToken offendingSymbol, int line, int charPositionInLine, string msg, RecognitionException e)
        {


            errorTextBox.AppendText(" line : " + line + " possotisn : " + charPositionInLine + " \n");


        }



    }

}
