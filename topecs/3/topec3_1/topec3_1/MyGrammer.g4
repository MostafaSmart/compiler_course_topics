grammar MyGrammer;

/*
 * Lexer Rules
 */

INT     : 'int';
DOUBLE  : 'double'; 

ID      : [a-zA-Z_] [a-zA-Z_0-9]*;

NUMBER  : [0-9]+('.'[0-9]+)?;

ASSIGNMENT : '=';

PLUS    : '+';
MINUS   : '-';
MUL     : '*';
DIV     : '/';

LIFT    : '(';
RIGHT   : ')';

SIMI    : ';';

COMA    : ',';

WS      : [ \t\r\n]+ -> skip;

INVALID : .;

/*
 * Parser Rules
 */

prog: statement SIMI EOF;

statement : firstDecl (COMA decler2)*;

firstDecl
    : (INT | DOUBLE) ID ASSIGNMENT expr 
    | (INT | DOUBLE) ID
    ;

decler2
    : (INT | DOUBLE)? ID ASSIGNMENT expr
    | (INT | DOUBLE)? ID
    ;

expr
    : expr PLUS term
    | expr MINUS term
    | term
    ;

term
    : term MUL factor
    | term DIV factor
    | factor
    ;

factor
    : NUMBER
    | LIFT expr RIGHT
    | ID
    ;
