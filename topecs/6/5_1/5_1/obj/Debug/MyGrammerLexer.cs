//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\SMART\Documents\Visual Studio 2012\Projects\5_1\5_1\MyGrammer.g4 by ANTLR 4.6.6

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace _5_1 {
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public partial class MyGrammerLexer : Lexer {
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, T__7=8, T__8=9, 
		START=10, END=11, PLUS=12, MINUS=13, MUL=14, DIV=15, LIFT=16, RIGHT=17, 
		LT=18, GT=19, AQU=20, NOTAQU=21, NUMBER=22, IDENTIFIER=23, WS=24;
	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "T__1", "T__2", "T__3", "T__4", "T__5", "T__6", "T__7", "T__8", 
		"START", "END", "PLUS", "MINUS", "MUL", "DIV", "LIFT", "RIGHT", "LT", 
		"GT", "AQU", "NOTAQU", "NUMBER", "IDENTIFIER", "WS"
	};


	public MyGrammerLexer(ICharStream input)
		: base(input)
	{
		_interp = new LexerATNSimulator(this,_ATN);
	}

	private static readonly string[] _LiteralNames = {
		null, "'int'", "','", "';'", "'='", "'if'", "'else'", "'{'", "'}'", "'print'", 
		"'Start'", "'End'", "'+'", "'-'", "'*'", "'/'", "'('", "')'", "'<'", "'>'", 
		"'=='", "'!='"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, null, null, null, null, "START", "END", 
		"PLUS", "MINUS", "MUL", "DIV", "LIFT", "RIGHT", "LT", "GT", "AQU", "NOTAQU", 
		"NUMBER", "IDENTIFIER", "WS"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[System.Obsolete("Use Vocabulary instead.")]
	public static readonly string[] tokenNames = GenerateTokenNames(DefaultVocabulary, _SymbolicNames.Length);

	private static string[] GenerateTokenNames(IVocabulary vocabulary, int length) {
		string[] tokenNames = new string[length];
		for (int i = 0; i < tokenNames.Length; i++) {
			tokenNames[i] = vocabulary.GetLiteralName(i);
			if (tokenNames[i] == null) {
				tokenNames[i] = vocabulary.GetSymbolicName(i);
			}

			if (tokenNames[i] == null) {
				tokenNames[i] = "<INVALID>";
			}
		}

		return tokenNames;
	}

	[System.Obsolete("Use IRecognizer.Vocabulary instead.")]
	public override string[] TokenNames
	{
		get
		{
			return tokenNames;
		}
	}

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "MyGrammer.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return _serializedATN; } }

	public static readonly string _serializedATN =
		"\x3\xAF6F\x8320\x479D\xB75C\x4880\x1605\x191C\xAB37\x2\x1A\x82\b\x1\x4"+
		"\x2\t\x2\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t\x6\x4\a\t\a\x4\b\t\b"+
		"\x4\t\t\t\x4\n\t\n\x4\v\t\v\x4\f\t\f\x4\r\t\r\x4\xE\t\xE\x4\xF\t\xF\x4"+
		"\x10\t\x10\x4\x11\t\x11\x4\x12\t\x12\x4\x13\t\x13\x4\x14\t\x14\x4\x15"+
		"\t\x15\x4\x16\t\x16\x4\x17\t\x17\x4\x18\t\x18\x4\x19\t\x19\x3\x2\x3\x2"+
		"\x3\x2\x3\x2\x3\x3\x3\x3\x3\x4\x3\x4\x3\x5\x3\x5\x3\x6\x3\x6\x3\x6\x3"+
		"\a\x3\a\x3\a\x3\a\x3\a\x3\b\x3\b\x3\t\x3\t\x3\n\x3\n\x3\n\x3\n\x3\n\x3"+
		"\n\x3\v\x3\v\x3\v\x3\v\x3\v\x3\v\x3\f\x3\f\x3\f\x3\f\x3\r\x3\r\x3\xE\x3"+
		"\xE\x3\xF\x3\xF\x3\x10\x3\x10\x3\x11\x3\x11\x3\x12\x3\x12\x3\x13\x3\x13"+
		"\x3\x14\x3\x14\x3\x15\x3\x15\x3\x15\x3\x16\x3\x16\x3\x16\x3\x17\x6\x17"+
		"q\n\x17\r\x17\xE\x17r\x3\x18\x3\x18\a\x18w\n\x18\f\x18\xE\x18z\v\x18\x3"+
		"\x19\x6\x19}\n\x19\r\x19\xE\x19~\x3\x19\x3\x19\x2\x2\x2\x1A\x3\x2\x3\x5"+
		"\x2\x4\a\x2\x5\t\x2\x6\v\x2\a\r\x2\b\xF\x2\t\x11\x2\n\x13\x2\v\x15\x2"+
		"\f\x17\x2\r\x19\x2\xE\x1B\x2\xF\x1D\x2\x10\x1F\x2\x11!\x2\x12#\x2\x13"+
		"%\x2\x14\'\x2\x15)\x2\x16+\x2\x17-\x2\x18/\x2\x19\x31\x2\x1A\x3\x2\x6"+
		"\x3\x2\x32;\x5\x2\x43\\\x61\x61\x63|\x6\x2\x32;\x43\\\x61\x61\x63|\x5"+
		"\x2\v\f\xF\xF\"\"\x84\x2\x3\x3\x2\x2\x2\x2\x5\x3\x2\x2\x2\x2\a\x3\x2\x2"+
		"\x2\x2\t\x3\x2\x2\x2\x2\v\x3\x2\x2\x2\x2\r\x3\x2\x2\x2\x2\xF\x3\x2\x2"+
		"\x2\x2\x11\x3\x2\x2\x2\x2\x13\x3\x2\x2\x2\x2\x15\x3\x2\x2\x2\x2\x17\x3"+
		"\x2\x2\x2\x2\x19\x3\x2\x2\x2\x2\x1B\x3\x2\x2\x2\x2\x1D\x3\x2\x2\x2\x2"+
		"\x1F\x3\x2\x2\x2\x2!\x3\x2\x2\x2\x2#\x3\x2\x2\x2\x2%\x3\x2\x2\x2\x2\'"+
		"\x3\x2\x2\x2\x2)\x3\x2\x2\x2\x2+\x3\x2\x2\x2\x2-\x3\x2\x2\x2\x2/\x3\x2"+
		"\x2\x2\x2\x31\x3\x2\x2\x2\x3\x33\x3\x2\x2\x2\x5\x37\x3\x2\x2\x2\a\x39"+
		"\x3\x2\x2\x2\t;\x3\x2\x2\x2\v=\x3\x2\x2\x2\r@\x3\x2\x2\x2\xF\x45\x3\x2"+
		"\x2\x2\x11G\x3\x2\x2\x2\x13I\x3\x2\x2\x2\x15O\x3\x2\x2\x2\x17U\x3\x2\x2"+
		"\x2\x19Y\x3\x2\x2\x2\x1B[\x3\x2\x2\x2\x1D]\x3\x2\x2\x2\x1F_\x3\x2\x2\x2"+
		"!\x61\x3\x2\x2\x2#\x63\x3\x2\x2\x2%\x65\x3\x2\x2\x2\'g\x3\x2\x2\x2)i\x3"+
		"\x2\x2\x2+l\x3\x2\x2\x2-p\x3\x2\x2\x2/t\x3\x2\x2\x2\x31|\x3\x2\x2\x2\x33"+
		"\x34\ak\x2\x2\x34\x35\ap\x2\x2\x35\x36\av\x2\x2\x36\x4\x3\x2\x2\x2\x37"+
		"\x38\a.\x2\x2\x38\x6\x3\x2\x2\x2\x39:\a=\x2\x2:\b\x3\x2\x2\x2;<\a?\x2"+
		"\x2<\n\x3\x2\x2\x2=>\ak\x2\x2>?\ah\x2\x2?\f\x3\x2\x2\x2@\x41\ag\x2\x2"+
		"\x41\x42\an\x2\x2\x42\x43\au\x2\x2\x43\x44\ag\x2\x2\x44\xE\x3\x2\x2\x2"+
		"\x45\x46\a}\x2\x2\x46\x10\x3\x2\x2\x2GH\a\x7F\x2\x2H\x12\x3\x2\x2\x2I"+
		"J\ar\x2\x2JK\at\x2\x2KL\ak\x2\x2LM\ap\x2\x2MN\av\x2\x2N\x14\x3\x2\x2\x2"+
		"OP\aU\x2\x2PQ\av\x2\x2QR\a\x63\x2\x2RS\at\x2\x2ST\av\x2\x2T\x16\x3\x2"+
		"\x2\x2UV\aG\x2\x2VW\ap\x2\x2WX\a\x66\x2\x2X\x18\x3\x2\x2\x2YZ\a-\x2\x2"+
		"Z\x1A\x3\x2\x2\x2[\\\a/\x2\x2\\\x1C\x3\x2\x2\x2]^\a,\x2\x2^\x1E\x3\x2"+
		"\x2\x2_`\a\x31\x2\x2` \x3\x2\x2\x2\x61\x62\a*\x2\x2\x62\"\x3\x2\x2\x2"+
		"\x63\x64\a+\x2\x2\x64$\x3\x2\x2\x2\x65\x66\a>\x2\x2\x66&\x3\x2\x2\x2g"+
		"h\a@\x2\x2h(\x3\x2\x2\x2ij\a?\x2\x2jk\a?\x2\x2k*\x3\x2\x2\x2lm\a#\x2\x2"+
		"mn\a?\x2\x2n,\x3\x2\x2\x2oq\t\x2\x2\x2po\x3\x2\x2\x2qr\x3\x2\x2\x2rp\x3"+
		"\x2\x2\x2rs\x3\x2\x2\x2s.\x3\x2\x2\x2tx\t\x3\x2\x2uw\t\x4\x2\x2vu\x3\x2"+
		"\x2\x2wz\x3\x2\x2\x2xv\x3\x2\x2\x2xy\x3\x2\x2\x2y\x30\x3\x2\x2\x2zx\x3"+
		"\x2\x2\x2{}\t\x5\x2\x2|{\x3\x2\x2\x2}~\x3\x2\x2\x2~|\x3\x2\x2\x2~\x7F"+
		"\x3\x2\x2\x2\x7F\x80\x3\x2\x2\x2\x80\x81\b\x19\x2\x2\x81\x32\x3\x2\x2"+
		"\x2\x6\x2rx~\x3\b\x2\x2";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
} // namespace _5_1
