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
using Antlr4.Runtime.Tree;
using System.Collections.Generic;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public partial class MyGrammerParser : Parser {
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, T__7=8, T__8=9, 
		START=10, END=11, PLUS=12, MINUS=13, MUL=14, DIV=15, LIFT=16, RIGHT=17, 
		LT=18, GT=19, AQU=20, NOTAQU=21, NUMBER=22, IDENTIFIER=23, WS=24;
	public const int
		RULE_program = 0, RULE_statement = 1, RULE_variableDeclaration = 2, RULE_variable = 3, 
		RULE_ifStatement = 4, RULE_elseStat = 5, RULE_block = 6, RULE_printStatement = 7, 
		RULE_comparisonExpression = 8, RULE_expr = 9, RULE_term = 10, RULE_factor = 11;
	public static readonly string[] ruleNames = {
		"program", "statement", "variableDeclaration", "variable", "ifStatement", 
		"elseStat", "block", "printStatement", "comparisonExpression", "expr", 
		"term", "factor"
	};

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

	public override string SerializedAtn { get { return _serializedATN; } }

	public MyGrammerParser(ITokenStream input)
		: base(input)
	{
		_interp = new ParserATNSimulator(this,_ATN);
	}
	public partial class ProgramContext : ParserRuleContext {
		public StatementContext[] statement() {
			return GetRuleContexts<StatementContext>();
		}
		public StatementContext statement(int i) {
			return GetRuleContext<StatementContext>(i);
		}
		public ProgramContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_program; } }
		public override void EnterRule(IParseTreeListener listener) {
			IMyGrammerListener typedListener = listener as IMyGrammerListener;
			if (typedListener != null) typedListener.EnterProgram(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IMyGrammerListener typedListener = listener as IMyGrammerListener;
			if (typedListener != null) typedListener.ExitProgram(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMyGrammerVisitor<TResult> typedVisitor = visitor as IMyGrammerVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitProgram(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ProgramContext program() {
		ProgramContext _localctx = new ProgramContext(_ctx, State);
		EnterRule(_localctx, 0, RULE_program);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 24; Match(START);
			State = 28;
			_errHandler.Sync(this);
			_la = _input.La(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__4) | (1L << T__6) | (1L << T__8))) != 0)) {
				{
				{
				State = 25; statement();
				}
				}
				State = 30;
				_errHandler.Sync(this);
				_la = _input.La(1);
			}
			State = 31; Match(END);
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

	public partial class StatementContext : ParserRuleContext {
		public VariableDeclarationContext variableDeclaration() {
			return GetRuleContext<VariableDeclarationContext>(0);
		}
		public IfStatementContext ifStatement() {
			return GetRuleContext<IfStatementContext>(0);
		}
		public PrintStatementContext printStatement() {
			return GetRuleContext<PrintStatementContext>(0);
		}
		public BlockContext block() {
			return GetRuleContext<BlockContext>(0);
		}
		public StatementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_statement; } }
		public override void EnterRule(IParseTreeListener listener) {
			IMyGrammerListener typedListener = listener as IMyGrammerListener;
			if (typedListener != null) typedListener.EnterStatement(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IMyGrammerListener typedListener = listener as IMyGrammerListener;
			if (typedListener != null) typedListener.ExitStatement(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMyGrammerVisitor<TResult> typedVisitor = visitor as IMyGrammerVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitStatement(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public StatementContext statement() {
		StatementContext _localctx = new StatementContext(_ctx, State);
		EnterRule(_localctx, 2, RULE_statement);
		try {
			State = 37;
			_errHandler.Sync(this);
			switch (_input.La(1)) {
			case T__0:
				EnterOuterAlt(_localctx, 1);
				{
				State = 33; variableDeclaration();
				}
				break;
			case T__4:
				EnterOuterAlt(_localctx, 2);
				{
				State = 34; ifStatement();
				}
				break;
			case T__8:
				EnterOuterAlt(_localctx, 3);
				{
				State = 35; printStatement();
				}
				break;
			case T__6:
				EnterOuterAlt(_localctx, 4);
				{
				State = 36; block();
				}
				break;
			default:
				throw new NoViableAltException(this);
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

	public partial class VariableDeclarationContext : ParserRuleContext {
		public VariableContext[] variable() {
			return GetRuleContexts<VariableContext>();
		}
		public VariableContext variable(int i) {
			return GetRuleContext<VariableContext>(i);
		}
		public VariableDeclarationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_variableDeclaration; } }
		public override void EnterRule(IParseTreeListener listener) {
			IMyGrammerListener typedListener = listener as IMyGrammerListener;
			if (typedListener != null) typedListener.EnterVariableDeclaration(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IMyGrammerListener typedListener = listener as IMyGrammerListener;
			if (typedListener != null) typedListener.ExitVariableDeclaration(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMyGrammerVisitor<TResult> typedVisitor = visitor as IMyGrammerVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitVariableDeclaration(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public VariableDeclarationContext variableDeclaration() {
		VariableDeclarationContext _localctx = new VariableDeclarationContext(_ctx, State);
		EnterRule(_localctx, 4, RULE_variableDeclaration);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 39; Match(T__0);
			State = 40; variable();
			State = 45;
			_errHandler.Sync(this);
			_la = _input.La(1);
			while (_la==T__1) {
				{
				{
				State = 41; Match(T__1);
				State = 42; variable();
				}
				}
				State = 47;
				_errHandler.Sync(this);
				_la = _input.La(1);
			}
			State = 48; Match(T__2);
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

	public partial class VariableContext : ParserRuleContext {
		public ITerminalNode IDENTIFIER() { return GetToken(MyGrammerParser.IDENTIFIER, 0); }
		public ExprContext expr() {
			return GetRuleContext<ExprContext>(0);
		}
		public VariableContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_variable; } }
		public override void EnterRule(IParseTreeListener listener) {
			IMyGrammerListener typedListener = listener as IMyGrammerListener;
			if (typedListener != null) typedListener.EnterVariable(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IMyGrammerListener typedListener = listener as IMyGrammerListener;
			if (typedListener != null) typedListener.ExitVariable(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMyGrammerVisitor<TResult> typedVisitor = visitor as IMyGrammerVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitVariable(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public VariableContext variable() {
		VariableContext _localctx = new VariableContext(_ctx, State);
		EnterRule(_localctx, 6, RULE_variable);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 50; Match(IDENTIFIER);
			State = 53;
			_errHandler.Sync(this);
			_la = _input.La(1);
			if (_la==T__3) {
				{
				State = 51; Match(T__3);
				State = 52; expr(0);
				}
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

	public partial class IfStatementContext : ParserRuleContext {
		public ComparisonExpressionContext comparisonExpression() {
			return GetRuleContext<ComparisonExpressionContext>(0);
		}
		public BlockContext block() {
			return GetRuleContext<BlockContext>(0);
		}
		public ElseStatContext elseStat() {
			return GetRuleContext<ElseStatContext>(0);
		}
		public IfStatementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_ifStatement; } }
		public override void EnterRule(IParseTreeListener listener) {
			IMyGrammerListener typedListener = listener as IMyGrammerListener;
			if (typedListener != null) typedListener.EnterIfStatement(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IMyGrammerListener typedListener = listener as IMyGrammerListener;
			if (typedListener != null) typedListener.ExitIfStatement(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMyGrammerVisitor<TResult> typedVisitor = visitor as IMyGrammerVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitIfStatement(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public IfStatementContext ifStatement() {
		IfStatementContext _localctx = new IfStatementContext(_ctx, State);
		EnterRule(_localctx, 8, RULE_ifStatement);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 55; Match(T__4);
			State = 56; Match(LIFT);
			State = 57; comparisonExpression();
			State = 58; Match(RIGHT);
			State = 59; block();
			State = 61;
			_errHandler.Sync(this);
			_la = _input.La(1);
			if (_la==T__5) {
				{
				State = 60; elseStat();
				}
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

	public partial class ElseStatContext : ParserRuleContext {
		public BlockContext block() {
			return GetRuleContext<BlockContext>(0);
		}
		public ElseStatContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_elseStat; } }
		public override void EnterRule(IParseTreeListener listener) {
			IMyGrammerListener typedListener = listener as IMyGrammerListener;
			if (typedListener != null) typedListener.EnterElseStat(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IMyGrammerListener typedListener = listener as IMyGrammerListener;
			if (typedListener != null) typedListener.ExitElseStat(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMyGrammerVisitor<TResult> typedVisitor = visitor as IMyGrammerVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitElseStat(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ElseStatContext elseStat() {
		ElseStatContext _localctx = new ElseStatContext(_ctx, State);
		EnterRule(_localctx, 10, RULE_elseStat);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 63; Match(T__5);
			State = 64; block();
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

	public partial class BlockContext : ParserRuleContext {
		public StatementContext[] statement() {
			return GetRuleContexts<StatementContext>();
		}
		public StatementContext statement(int i) {
			return GetRuleContext<StatementContext>(i);
		}
		public BlockContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_block; } }
		public override void EnterRule(IParseTreeListener listener) {
			IMyGrammerListener typedListener = listener as IMyGrammerListener;
			if (typedListener != null) typedListener.EnterBlock(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IMyGrammerListener typedListener = listener as IMyGrammerListener;
			if (typedListener != null) typedListener.ExitBlock(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMyGrammerVisitor<TResult> typedVisitor = visitor as IMyGrammerVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitBlock(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public BlockContext block() {
		BlockContext _localctx = new BlockContext(_ctx, State);
		EnterRule(_localctx, 12, RULE_block);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 66; Match(T__6);
			State = 70;
			_errHandler.Sync(this);
			_la = _input.La(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__4) | (1L << T__6) | (1L << T__8))) != 0)) {
				{
				{
				State = 67; statement();
				}
				}
				State = 72;
				_errHandler.Sync(this);
				_la = _input.La(1);
			}
			State = 73; Match(T__7);
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

	public partial class PrintStatementContext : ParserRuleContext {
		public ExprContext expr() {
			return GetRuleContext<ExprContext>(0);
		}
		public PrintStatementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_printStatement; } }
		public override void EnterRule(IParseTreeListener listener) {
			IMyGrammerListener typedListener = listener as IMyGrammerListener;
			if (typedListener != null) typedListener.EnterPrintStatement(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IMyGrammerListener typedListener = listener as IMyGrammerListener;
			if (typedListener != null) typedListener.ExitPrintStatement(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMyGrammerVisitor<TResult> typedVisitor = visitor as IMyGrammerVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitPrintStatement(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public PrintStatementContext printStatement() {
		PrintStatementContext _localctx = new PrintStatementContext(_ctx, State);
		EnterRule(_localctx, 14, RULE_printStatement);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 75; Match(T__8);
			State = 76; Match(LIFT);
			State = 77; expr(0);
			State = 78; Match(RIGHT);
			State = 79; Match(T__2);
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

	public partial class ComparisonExpressionContext : ParserRuleContext {
		public ExprContext[] expr() {
			return GetRuleContexts<ExprContext>();
		}
		public ExprContext expr(int i) {
			return GetRuleContext<ExprContext>(i);
		}
		public ITerminalNode LT() { return GetToken(MyGrammerParser.LT, 0); }
		public ITerminalNode GT() { return GetToken(MyGrammerParser.GT, 0); }
		public ITerminalNode AQU() { return GetToken(MyGrammerParser.AQU, 0); }
		public ITerminalNode NOTAQU() { return GetToken(MyGrammerParser.NOTAQU, 0); }
		public ComparisonExpressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_comparisonExpression; } }
		public override void EnterRule(IParseTreeListener listener) {
			IMyGrammerListener typedListener = listener as IMyGrammerListener;
			if (typedListener != null) typedListener.EnterComparisonExpression(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IMyGrammerListener typedListener = listener as IMyGrammerListener;
			if (typedListener != null) typedListener.ExitComparisonExpression(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMyGrammerVisitor<TResult> typedVisitor = visitor as IMyGrammerVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitComparisonExpression(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ComparisonExpressionContext comparisonExpression() {
		ComparisonExpressionContext _localctx = new ComparisonExpressionContext(_ctx, State);
		EnterRule(_localctx, 16, RULE_comparisonExpression);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 81; expr(0);
			State = 82;
			_la = _input.La(1);
			if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << LT) | (1L << GT) | (1L << AQU) | (1L << NOTAQU))) != 0)) ) {
			_errHandler.RecoverInline(this);
			} else {
				if (_input.La(1) == TokenConstants.Eof) {
					matchedEOF = true;
				}

				_errHandler.ReportMatch(this);
				Consume();
			}
			State = 83; expr(0);
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
		public ExprContext expr() {
			return GetRuleContext<ExprContext>(0);
		}
		public ITerminalNode PLUS() { return GetToken(MyGrammerParser.PLUS, 0); }
		public TermContext term() {
			return GetRuleContext<TermContext>(0);
		}
		public ITerminalNode MINUS() { return GetToken(MyGrammerParser.MINUS, 0); }
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
		return expr(0);
	}

	private ExprContext expr(int _p) {
		ParserRuleContext _parentctx = _ctx;
		int _parentState = State;
		ExprContext _localctx = new ExprContext(_ctx, _parentState);
		ExprContext _prevctx = _localctx;
		int _startState = 18;
		EnterRecursionRule(_localctx, 18, RULE_expr, _p);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			{
			State = 86; term(0);
			}
			_ctx.stop = _input.Lt(-1);
			State = 96;
			_errHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(_input,7,_ctx);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.InvalidAltNumber ) {
				if ( _alt==1 ) {
					if ( _parseListeners!=null ) TriggerExitRuleEvent();
					_prevctx = _localctx;
					{
					State = 94;
					_errHandler.Sync(this);
					switch ( Interpreter.AdaptivePredict(_input,6,_ctx) ) {
					case 1:
						{
						_localctx = new ExprContext(_parentctx, _parentState);
						PushNewRecursionContext(_localctx, _startState, RULE_expr);
						State = 88;
						if (!(Precpred(_ctx, 3))) throw new FailedPredicateException(this, "Precpred(_ctx, 3)");
						State = 89; Match(PLUS);
						State = 90; term(0);
						}
						break;

					case 2:
						{
						_localctx = new ExprContext(_parentctx, _parentState);
						PushNewRecursionContext(_localctx, _startState, RULE_expr);
						State = 91;
						if (!(Precpred(_ctx, 2))) throw new FailedPredicateException(this, "Precpred(_ctx, 2)");
						State = 92; Match(MINUS);
						State = 93; term(0);
						}
						break;
					}
					} 
				}
				State = 98;
				_errHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(_input,7,_ctx);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			UnrollRecursionContexts(_parentctx);
		}
		return _localctx;
	}

	public partial class TermContext : ParserRuleContext {
		public TermContext term() {
			return GetRuleContext<TermContext>(0);
		}
		public ITerminalNode MUL() { return GetToken(MyGrammerParser.MUL, 0); }
		public FactorContext factor() {
			return GetRuleContext<FactorContext>(0);
		}
		public ITerminalNode DIV() { return GetToken(MyGrammerParser.DIV, 0); }
		public TermContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_term; } }
		public override void EnterRule(IParseTreeListener listener) {
			IMyGrammerListener typedListener = listener as IMyGrammerListener;
			if (typedListener != null) typedListener.EnterTerm(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IMyGrammerListener typedListener = listener as IMyGrammerListener;
			if (typedListener != null) typedListener.ExitTerm(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMyGrammerVisitor<TResult> typedVisitor = visitor as IMyGrammerVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitTerm(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public TermContext term() {
		return term(0);
	}

	private TermContext term(int _p) {
		ParserRuleContext _parentctx = _ctx;
		int _parentState = State;
		TermContext _localctx = new TermContext(_ctx, _parentState);
		TermContext _prevctx = _localctx;
		int _startState = 20;
		EnterRecursionRule(_localctx, 20, RULE_term, _p);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			{
			State = 100; factor();
			}
			_ctx.stop = _input.Lt(-1);
			State = 110;
			_errHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(_input,9,_ctx);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.InvalidAltNumber ) {
				if ( _alt==1 ) {
					if ( _parseListeners!=null ) TriggerExitRuleEvent();
					_prevctx = _localctx;
					{
					State = 108;
					_errHandler.Sync(this);
					switch ( Interpreter.AdaptivePredict(_input,8,_ctx) ) {
					case 1:
						{
						_localctx = new TermContext(_parentctx, _parentState);
						PushNewRecursionContext(_localctx, _startState, RULE_term);
						State = 102;
						if (!(Precpred(_ctx, 3))) throw new FailedPredicateException(this, "Precpred(_ctx, 3)");
						State = 103; Match(MUL);
						State = 104; factor();
						}
						break;

					case 2:
						{
						_localctx = new TermContext(_parentctx, _parentState);
						PushNewRecursionContext(_localctx, _startState, RULE_term);
						State = 105;
						if (!(Precpred(_ctx, 2))) throw new FailedPredicateException(this, "Precpred(_ctx, 2)");
						State = 106; Match(DIV);
						State = 107; factor();
						}
						break;
					}
					} 
				}
				State = 112;
				_errHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(_input,9,_ctx);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			UnrollRecursionContexts(_parentctx);
		}
		return _localctx;
	}

	public partial class FactorContext : ParserRuleContext {
		public ITerminalNode NUMBER() { return GetToken(MyGrammerParser.NUMBER, 0); }
		public ITerminalNode LIFT() { return GetToken(MyGrammerParser.LIFT, 0); }
		public ExprContext expr() {
			return GetRuleContext<ExprContext>(0);
		}
		public ITerminalNode RIGHT() { return GetToken(MyGrammerParser.RIGHT, 0); }
		public ITerminalNode IDENTIFIER() { return GetToken(MyGrammerParser.IDENTIFIER, 0); }
		public FactorContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_factor; } }
		public override void EnterRule(IParseTreeListener listener) {
			IMyGrammerListener typedListener = listener as IMyGrammerListener;
			if (typedListener != null) typedListener.EnterFactor(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IMyGrammerListener typedListener = listener as IMyGrammerListener;
			if (typedListener != null) typedListener.ExitFactor(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMyGrammerVisitor<TResult> typedVisitor = visitor as IMyGrammerVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitFactor(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public FactorContext factor() {
		FactorContext _localctx = new FactorContext(_ctx, State);
		EnterRule(_localctx, 22, RULE_factor);
		try {
			State = 119;
			_errHandler.Sync(this);
			switch (_input.La(1)) {
			case NUMBER:
				EnterOuterAlt(_localctx, 1);
				{
				State = 113; Match(NUMBER);
				}
				break;
			case LIFT:
				EnterOuterAlt(_localctx, 2);
				{
				State = 114; Match(LIFT);
				State = 115; expr(0);
				State = 116; Match(RIGHT);
				}
				break;
			case IDENTIFIER:
				EnterOuterAlt(_localctx, 3);
				{
				State = 118; Match(IDENTIFIER);
				}
				break;
			default:
				throw new NoViableAltException(this);
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

	public override bool Sempred(RuleContext _localctx, int ruleIndex, int predIndex) {
		switch (ruleIndex) {
		case 9: return expr_sempred((ExprContext)_localctx, predIndex);

		case 10: return term_sempred((TermContext)_localctx, predIndex);
		}
		return true;
	}
	private bool expr_sempred(ExprContext _localctx, int predIndex) {
		switch (predIndex) {
		case 0: return Precpred(_ctx, 3);

		case 1: return Precpred(_ctx, 2);
		}
		return true;
	}
	private bool term_sempred(TermContext _localctx, int predIndex) {
		switch (predIndex) {
		case 2: return Precpred(_ctx, 3);

		case 3: return Precpred(_ctx, 2);
		}
		return true;
	}

	public static readonly string _serializedATN =
		"\x3\xAF6F\x8320\x479D\xB75C\x4880\x1605\x191C\xAB37\x3\x1A|\x4\x2\t\x2"+
		"\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t\x6\x4\a\t\a\x4\b\t\b\x4\t\t"+
		"\t\x4\n\t\n\x4\v\t\v\x4\f\t\f\x4\r\t\r\x3\x2\x3\x2\a\x2\x1D\n\x2\f\x2"+
		"\xE\x2 \v\x2\x3\x2\x3\x2\x3\x3\x3\x3\x3\x3\x3\x3\x5\x3(\n\x3\x3\x4\x3"+
		"\x4\x3\x4\x3\x4\a\x4.\n\x4\f\x4\xE\x4\x31\v\x4\x3\x4\x3\x4\x3\x5\x3\x5"+
		"\x3\x5\x5\x5\x38\n\x5\x3\x6\x3\x6\x3\x6\x3\x6\x3\x6\x3\x6\x5\x6@\n\x6"+
		"\x3\a\x3\a\x3\a\x3\b\x3\b\a\bG\n\b\f\b\xE\bJ\v\b\x3\b\x3\b\x3\t\x3\t\x3"+
		"\t\x3\t\x3\t\x3\t\x3\n\x3\n\x3\n\x3\n\x3\v\x3\v\x3\v\x3\v\x3\v\x3\v\x3"+
		"\v\x3\v\x3\v\a\v\x61\n\v\f\v\xE\v\x64\v\v\x3\f\x3\f\x3\f\x3\f\x3\f\x3"+
		"\f\x3\f\x3\f\x3\f\a\fo\n\f\f\f\xE\fr\v\f\x3\r\x3\r\x3\r\x3\r\x3\r\x3\r"+
		"\x5\rz\n\r\x3\r\x2\x2\x4\x14\x16\xE\x2\x2\x4\x2\x6\x2\b\x2\n\x2\f\x2\xE"+
		"\x2\x10\x2\x12\x2\x14\x2\x16\x2\x18\x2\x2\x3\x3\x2\x14\x17}\x2\x1A\x3"+
		"\x2\x2\x2\x4\'\x3\x2\x2\x2\x6)\x3\x2\x2\x2\b\x34\x3\x2\x2\x2\n\x39\x3"+
		"\x2\x2\x2\f\x41\x3\x2\x2\x2\xE\x44\x3\x2\x2\x2\x10M\x3\x2\x2\x2\x12S\x3"+
		"\x2\x2\x2\x14W\x3\x2\x2\x2\x16\x65\x3\x2\x2\x2\x18y\x3\x2\x2\x2\x1A\x1E"+
		"\a\f\x2\x2\x1B\x1D\x5\x4\x3\x2\x1C\x1B\x3\x2\x2\x2\x1D \x3\x2\x2\x2\x1E"+
		"\x1C\x3\x2\x2\x2\x1E\x1F\x3\x2\x2\x2\x1F!\x3\x2\x2\x2 \x1E\x3\x2\x2\x2"+
		"!\"\a\r\x2\x2\"\x3\x3\x2\x2\x2#(\x5\x6\x4\x2$(\x5\n\x6\x2%(\x5\x10\t\x2"+
		"&(\x5\xE\b\x2\'#\x3\x2\x2\x2\'$\x3\x2\x2\x2\'%\x3\x2\x2\x2\'&\x3\x2\x2"+
		"\x2(\x5\x3\x2\x2\x2)*\a\x3\x2\x2*/\x5\b\x5\x2+,\a\x4\x2\x2,.\x5\b\x5\x2"+
		"-+\x3\x2\x2\x2.\x31\x3\x2\x2\x2/-\x3\x2\x2\x2/\x30\x3\x2\x2\x2\x30\x32"+
		"\x3\x2\x2\x2\x31/\x3\x2\x2\x2\x32\x33\a\x5\x2\x2\x33\a\x3\x2\x2\x2\x34"+
		"\x37\a\x19\x2\x2\x35\x36\a\x6\x2\x2\x36\x38\x5\x14\v\x2\x37\x35\x3\x2"+
		"\x2\x2\x37\x38\x3\x2\x2\x2\x38\t\x3\x2\x2\x2\x39:\a\a\x2\x2:;\a\x12\x2"+
		"\x2;<\x5\x12\n\x2<=\a\x13\x2\x2=?\x5\xE\b\x2>@\x5\f\a\x2?>\x3\x2\x2\x2"+
		"?@\x3\x2\x2\x2@\v\x3\x2\x2\x2\x41\x42\a\b\x2\x2\x42\x43\x5\xE\b\x2\x43"+
		"\r\x3\x2\x2\x2\x44H\a\t\x2\x2\x45G\x5\x4\x3\x2\x46\x45\x3\x2\x2\x2GJ\x3"+
		"\x2\x2\x2H\x46\x3\x2\x2\x2HI\x3\x2\x2\x2IK\x3\x2\x2\x2JH\x3\x2\x2\x2K"+
		"L\a\n\x2\x2L\xF\x3\x2\x2\x2MN\a\v\x2\x2NO\a\x12\x2\x2OP\x5\x14\v\x2PQ"+
		"\a\x13\x2\x2QR\a\x5\x2\x2R\x11\x3\x2\x2\x2ST\x5\x14\v\x2TU\t\x2\x2\x2"+
		"UV\x5\x14\v\x2V\x13\x3\x2\x2\x2WX\b\v\x1\x2XY\x5\x16\f\x2Y\x62\x3\x2\x2"+
		"\x2Z[\f\x5\x2\x2[\\\a\xE\x2\x2\\\x61\x5\x16\f\x2]^\f\x4\x2\x2^_\a\xF\x2"+
		"\x2_\x61\x5\x16\f\x2`Z\x3\x2\x2\x2`]\x3\x2\x2\x2\x61\x64\x3\x2\x2\x2\x62"+
		"`\x3\x2\x2\x2\x62\x63\x3\x2\x2\x2\x63\x15\x3\x2\x2\x2\x64\x62\x3\x2\x2"+
		"\x2\x65\x66\b\f\x1\x2\x66g\x5\x18\r\x2gp\x3\x2\x2\x2hi\f\x5\x2\x2ij\a"+
		"\x10\x2\x2jo\x5\x18\r\x2kl\f\x4\x2\x2lm\a\x11\x2\x2mo\x5\x18\r\x2nh\x3"+
		"\x2\x2\x2nk\x3\x2\x2\x2or\x3\x2\x2\x2pn\x3\x2\x2\x2pq\x3\x2\x2\x2q\x17"+
		"\x3\x2\x2\x2rp\x3\x2\x2\x2sz\a\x18\x2\x2tu\a\x12\x2\x2uv\x5\x14\v\x2v"+
		"w\a\x13\x2\x2wz\x3\x2\x2\x2xz\a\x19\x2\x2ys\x3\x2\x2\x2yt\x3\x2\x2\x2"+
		"yx\x3\x2\x2\x2z\x19\x3\x2\x2\x2\r\x1E\'/\x37?H`\x62npy";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
} // namespace _5_1
