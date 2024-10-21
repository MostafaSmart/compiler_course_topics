grammar MyGrammer;


program : STARTPROGRAM declarlist ifStatement ENDPROGRAM ;

declarlist : declar (COMMA declar2)* SEMI; 


ifStatement : IF LIFT condition RIGHT BEGIN statements END ;


declar :INT ID ASSIGNMENT expr |INT ID  ;

declar2 : (INT)? ID ASSIGNMENT expr
       | (INT)? ID
       ;


condition : expr (GT|LT) expr ;

statements : prints SEMI ;

prints : PRINTT LIFT (expr) RIGHT ;

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





STARTPROGRAM : 'StartP';
ENDPROGRAM : 'EndP';
INT : 'int';
IF : 'if';
PRINTT : 'print';

ID : [a-zA-Z_] [a-zA-Z_0-9]*;
NUMBER : [0-9]+;
ASSIGNMENT : '=';
LIFT : '(';
RIGHT : ')';
BEGIN  : '{' ;

PLUS : '+' ;

MINUS : '-' ;

DIV : '/' ;

MUL : '*' ;



END : '}' ;
SEMI : ';';   
COMMA : ',';  
GT  : '>' ;
LT : '<' ;
WS : [ \t\r\n]+ -> skip;
INVALID : . ;
