//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\SMART\Documents\Visual Studio 2012\Projects\topecs\topec3_2\topec3_2\MyGrammer.g4 by ANTLR 4.6.6

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace topec3_2 {
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public partial class MyGrammerLexer : Lexer {
	public const int
		STARTPROGRAM=1, ENDPROGRAM=2, INT=3, IF=4, PRINTT=5, ID=6, NUMBER=7, ASSIGNMENT=8, 
		LIFT=9, RIGHT=10, BEGIN=11, PLUS=12, MINUS=13, DIV=14, MUL=15, END=16, 
		SEMI=17, COMMA=18, GT=19, LT=20, WS=21, INVALID=22;
	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"STARTPROGRAM", "ENDPROGRAM", "INT", "IF", "PRINTT", "ID", "NUMBER", "ASSIGNMENT", 
		"LIFT", "RIGHT", "BEGIN", "PLUS", "MINUS", "DIV", "MUL", "END", "SEMI", 
		"COMMA", "GT", "LT", "WS", "INVALID"
	};


	public MyGrammerLexer(ICharStream input)
		: base(input)
	{
		_interp = new LexerATNSimulator(this,_ATN);
	}

	private static readonly string[] _LiteralNames = {
		null, "'StartP'", "'EndP'", "'int'", "'if'", "'print'", null, null, "'='", 
		"'('", "')'", "'{'", "'+'", "'-'", "'/'", "'*'", "'}'", "';'", "','", 
		"'>'", "'<'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "STARTPROGRAM", "ENDPROGRAM", "INT", "IF", "PRINTT", "ID", "NUMBER", 
		"ASSIGNMENT", "LIFT", "RIGHT", "BEGIN", "PLUS", "MINUS", "DIV", "MUL", 
		"END", "SEMI", "COMMA", "GT", "LT", "WS", "INVALID"
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
		"\x3\xAF6F\x8320\x479D\xB75C\x4880\x1605\x191C\xAB37\x2\x18w\b\x1\x4\x2"+
		"\t\x2\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t\x6\x4\a\t\a\x4\b\t\b\x4"+
		"\t\t\t\x4\n\t\n\x4\v\t\v\x4\f\t\f\x4\r\t\r\x4\xE\t\xE\x4\xF\t\xF\x4\x10"+
		"\t\x10\x4\x11\t\x11\x4\x12\t\x12\x4\x13\t\x13\x4\x14\t\x14\x4\x15\t\x15"+
		"\x4\x16\t\x16\x4\x17\t\x17\x3\x2\x3\x2\x3\x2\x3\x2\x3\x2\x3\x2\x3\x2\x3"+
		"\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x4\x3\x4\x3\x4\x3\x4\x3\x5\x3\x5\x3\x5"+
		"\x3\x6\x3\x6\x3\x6\x3\x6\x3\x6\x3\x6\x3\a\x3\a\a\aK\n\a\f\a\xE\aN\v\a"+
		"\x3\b\x6\bQ\n\b\r\b\xE\bR\x3\t\x3\t\x3\n\x3\n\x3\v\x3\v\x3\f\x3\f\x3\r"+
		"\x3\r\x3\xE\x3\xE\x3\xF\x3\xF\x3\x10\x3\x10\x3\x11\x3\x11\x3\x12\x3\x12"+
		"\x3\x13\x3\x13\x3\x14\x3\x14\x3\x15\x3\x15\x3\x16\x6\x16p\n\x16\r\x16"+
		"\xE\x16q\x3\x16\x3\x16\x3\x17\x3\x17\x2\x2\x2\x18\x3\x2\x3\x5\x2\x4\a"+
		"\x2\x5\t\x2\x6\v\x2\a\r\x2\b\xF\x2\t\x11\x2\n\x13\x2\v\x15\x2\f\x17\x2"+
		"\r\x19\x2\xE\x1B\x2\xF\x1D\x2\x10\x1F\x2\x11!\x2\x12#\x2\x13%\x2\x14\'"+
		"\x2\x15)\x2\x16+\x2\x17-\x2\x18\x3\x2\x6\x5\x2\x43\\\x61\x61\x63|\x6\x2"+
		"\x32;\x43\\\x61\x61\x63|\x3\x2\x32;\x5\x2\v\f\xF\xF\"\"y\x2\x3\x3\x2\x2"+
		"\x2\x2\x5\x3\x2\x2\x2\x2\a\x3\x2\x2\x2\x2\t\x3\x2\x2\x2\x2\v\x3\x2\x2"+
		"\x2\x2\r\x3\x2\x2\x2\x2\xF\x3\x2\x2\x2\x2\x11\x3\x2\x2\x2\x2\x13\x3\x2"+
		"\x2\x2\x2\x15\x3\x2\x2\x2\x2\x17\x3\x2\x2\x2\x2\x19\x3\x2\x2\x2\x2\x1B"+
		"\x3\x2\x2\x2\x2\x1D\x3\x2\x2\x2\x2\x1F\x3\x2\x2\x2\x2!\x3\x2\x2\x2\x2"+
		"#\x3\x2\x2\x2\x2%\x3\x2\x2\x2\x2\'\x3\x2\x2\x2\x2)\x3\x2\x2\x2\x2+\x3"+
		"\x2\x2\x2\x2-\x3\x2\x2\x2\x3/\x3\x2\x2\x2\x5\x36\x3\x2\x2\x2\a;\x3\x2"+
		"\x2\x2\t?\x3\x2\x2\x2\v\x42\x3\x2\x2\x2\rH\x3\x2\x2\x2\xFP\x3\x2\x2\x2"+
		"\x11T\x3\x2\x2\x2\x13V\x3\x2\x2\x2\x15X\x3\x2\x2\x2\x17Z\x3\x2\x2\x2\x19"+
		"\\\x3\x2\x2\x2\x1B^\x3\x2\x2\x2\x1D`\x3\x2\x2\x2\x1F\x62\x3\x2\x2\x2!"+
		"\x64\x3\x2\x2\x2#\x66\x3\x2\x2\x2%h\x3\x2\x2\x2\'j\x3\x2\x2\x2)l\x3\x2"+
		"\x2\x2+o\x3\x2\x2\x2-u\x3\x2\x2\x2/\x30\aU\x2\x2\x30\x31\av\x2\x2\x31"+
		"\x32\a\x63\x2\x2\x32\x33\at\x2\x2\x33\x34\av\x2\x2\x34\x35\aR\x2\x2\x35"+
		"\x4\x3\x2\x2\x2\x36\x37\aG\x2\x2\x37\x38\ap\x2\x2\x38\x39\a\x66\x2\x2"+
		"\x39:\aR\x2\x2:\x6\x3\x2\x2\x2;<\ak\x2\x2<=\ap\x2\x2=>\av\x2\x2>\b\x3"+
		"\x2\x2\x2?@\ak\x2\x2@\x41\ah\x2\x2\x41\n\x3\x2\x2\x2\x42\x43\ar\x2\x2"+
		"\x43\x44\at\x2\x2\x44\x45\ak\x2\x2\x45\x46\ap\x2\x2\x46G\av\x2\x2G\f\x3"+
		"\x2\x2\x2HL\t\x2\x2\x2IK\t\x3\x2\x2JI\x3\x2\x2\x2KN\x3\x2\x2\x2LJ\x3\x2"+
		"\x2\x2LM\x3\x2\x2\x2M\xE\x3\x2\x2\x2NL\x3\x2\x2\x2OQ\t\x4\x2\x2PO\x3\x2"+
		"\x2\x2QR\x3\x2\x2\x2RP\x3\x2\x2\x2RS\x3\x2\x2\x2S\x10\x3\x2\x2\x2TU\a"+
		"?\x2\x2U\x12\x3\x2\x2\x2VW\a*\x2\x2W\x14\x3\x2\x2\x2XY\a+\x2\x2Y\x16\x3"+
		"\x2\x2\x2Z[\a}\x2\x2[\x18\x3\x2\x2\x2\\]\a-\x2\x2]\x1A\x3\x2\x2\x2^_\a"+
		"/\x2\x2_\x1C\x3\x2\x2\x2`\x61\a\x31\x2\x2\x61\x1E\x3\x2\x2\x2\x62\x63"+
		"\a,\x2\x2\x63 \x3\x2\x2\x2\x64\x65\a\x7F\x2\x2\x65\"\x3\x2\x2\x2\x66g"+
		"\a=\x2\x2g$\x3\x2\x2\x2hi\a.\x2\x2i&\x3\x2\x2\x2jk\a@\x2\x2k(\x3\x2\x2"+
		"\x2lm\a>\x2\x2m*\x3\x2\x2\x2np\t\x5\x2\x2on\x3\x2\x2\x2pq\x3\x2\x2\x2"+
		"qo\x3\x2\x2\x2qr\x3\x2\x2\x2rs\x3\x2\x2\x2st\b\x16\x2\x2t,\x3\x2\x2\x2"+
		"uv\v\x2\x2\x2v.\x3\x2\x2\x2\x6\x2LRq\x3\b\x2\x2";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
} // namespace topec3_2
