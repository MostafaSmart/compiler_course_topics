//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\SMART\Documents\Visual Studio 2012\Projects\test1_1\test1_1\MyGrammer.g4 by ANTLR 4.6.6

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace test1_1 {
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using System.Collections.Generic;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public partial class MyGrammerParser : Parser {
	public const int
		NUMBER=1, PLUS=2, MINUS=3, DIV=4, MULT=5, SIMI=6, WS=7, INVALID=8;
	public const int
		RULE_prog = 0, RULE_expr = 1, RULE_oprit = 2;
	public static readonly string[] ruleNames = {
		"prog", "expr", "oprit"
	};

	private static readonly string[] _LiteralNames = {
		null, null, "'+'", "'-'", "'/'", "'*'", "';'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "NUMBER", "PLUS", "MINUS", "DIV", "MULT", "SIMI", "WS", "INVALID"
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

	public override string SerializedAtn { get { return _serializedATN; } }

	public MyGrammerParser(ITokenStream input)
		: base(input)
	{
		_interp = new ParserATNSimulator(this,_ATN);
	}
	public partial class ProgContext : ParserRuleContext {
		public ExprContext[] expr() {
			return GetRuleContexts<ExprContext>();
		}
		public ExprContext expr(int i) {
			return GetRuleContext<ExprContext>(i);
		}
		public ITerminalNode[] SIMI() { return GetTokens(MyGrammerParser.SIMI); }
		public ITerminalNode SIMI(int i) {
			return GetToken(MyGrammerParser.SIMI, i);
		}
		public ITerminalNode Eof() { return GetToken(MyGrammerParser.Eof, 0); }
		public ProgContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_prog; } }
		public override void EnterRule(IParseTreeListener listener) {
			IMyGrammerListener typedListener = listener as IMyGrammerListener;
			if (typedListener != null) typedListener.EnterProg(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IMyGrammerListener typedListener = listener as IMyGrammerListener;
			if (typedListener != null) typedListener.ExitProg(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMyGrammerVisitor<TResult> typedVisitor = visitor as IMyGrammerVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitProg(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ProgContext prog() {
		ProgContext _localctx = new ProgContext(_ctx, State);
		EnterRule(_localctx, 0, RULE_prog);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 6; expr();
			State = 11;
			_errHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(_input,0,_ctx);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.InvalidAltNumber ) {
				if ( _alt==1 ) {
					{
					{
					State = 7; Match(SIMI);
					State = 8; expr();
					}
					} 
				}
				State = 13;
				_errHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(_input,0,_ctx);
			}
			State = 14; Match(SIMI);
			State = 15; Match(Eof);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ExprContext : ParserRuleContext {
		public ITerminalNode[] NUMBER() { return GetTokens(MyGrammerParser.NUMBER); }
		public ITerminalNode NUMBER(int i) {
			return GetToken(MyGrammerParser.NUMBER, i);
		}
		public OpritContext oprit() {
			return GetRuleContext<OpritContext>(0);
		}
		public ExprContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_expr; } }
		public override void EnterRule(IParseTreeListener listener) {
			IMyGrammerListener typedListener = listener as IMyGrammerListener;
			if (typedListener != null) typedListener.EnterExpr(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IMyGrammerListener typedListener = listener as IMyGrammerListener;
			if (typedListener != null) typedListener.ExitExpr(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMyGrammerVisitor<TResult> typedVisitor = visitor as IMyGrammerVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitExpr(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ExprContext expr() {
		ExprContext _localctx = new ExprContext(_ctx, State);
		EnterRule(_localctx, 2, RULE_expr);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 17; Match(NUMBER);
			State = 18; oprit();
			State = 19; Match(NUMBER);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class OpritContext : ParserRuleContext {
		public ITerminalNode PLUS() { return GetToken(MyGrammerParser.PLUS, 0); }
		public ITerminalNode MINUS() { return GetToken(MyGrammerParser.MINUS, 0); }
		public ITerminalNode DIV() { return GetToken(MyGrammerParser.DIV, 0); }
		public ITerminalNode MULT() { return GetToken(MyGrammerParser.MULT, 0); }
		public OpritContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_oprit; } }
		public override void EnterRule(IParseTreeListener listener) {
			IMyGrammerListener typedListener = listener as IMyGrammerListener;
			if (typedListener != null) typedListener.EnterOprit(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IMyGrammerListener typedListener = listener as IMyGrammerListener;
			if (typedListener != null) typedListener.ExitOprit(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMyGrammerVisitor<TResult> typedVisitor = visitor as IMyGrammerVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitOprit(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public OpritContext oprit() {
		OpritContext _localctx = new OpritContext(_ctx, State);
		EnterRule(_localctx, 4, RULE_oprit);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 21;
			_la = _input.La(1);
			if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << PLUS) | (1L << MINUS) | (1L << DIV) | (1L << MULT))) != 0)) ) {
			_errHandler.RecoverInline(this);
			} else {
				if (_input.La(1) == TokenConstants.Eof) {
					matchedEOF = true;
				}

				_errHandler.ReportMatch(this);
				Consume();
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public static readonly string _serializedATN =
		"\x3\xAF6F\x8320\x479D\xB75C\x4880\x1605\x191C\xAB37\x3\n\x1A\x4\x2\t\x2"+
		"\x4\x3\t\x3\x4\x4\t\x4\x3\x2\x3\x2\x3\x2\a\x2\f\n\x2\f\x2\xE\x2\xF\v\x2"+
		"\x3\x2\x3\x2\x3\x2\x3\x3\x3\x3\x3\x3\x3\x3\x3\x4\x3\x4\x3\x4\x2\x2\x2"+
		"\x5\x2\x2\x4\x2\x6\x2\x2\x3\x3\x2\x4\a\x17\x2\b\x3\x2\x2\x2\x4\x13\x3"+
		"\x2\x2\x2\x6\x17\x3\x2\x2\x2\b\r\x5\x4\x3\x2\t\n\a\b\x2\x2\n\f\x5\x4\x3"+
		"\x2\v\t\x3\x2\x2\x2\f\xF\x3\x2\x2\x2\r\v\x3\x2\x2\x2\r\xE\x3\x2\x2\x2"+
		"\xE\x10\x3\x2\x2\x2\xF\r\x3\x2\x2\x2\x10\x11\a\b\x2\x2\x11\x12\a\x2\x2"+
		"\x3\x12\x3\x3\x2\x2\x2\x13\x14\a\x3\x2\x2\x14\x15\x5\x6\x4\x2\x15\x16"+
		"\a\x3\x2\x2\x16\x5\x3\x2\x2\x2\x17\x18\t\x2\x2\x2\x18\a\x3\x2\x2\x2\x3"+
		"\r";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
} // namespace test1_1
