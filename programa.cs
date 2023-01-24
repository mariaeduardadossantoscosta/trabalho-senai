usando  Sistema ;
namespace  Atividade
{
 programa de classe
{
static  void  Main ( string [] args ) { float  val_pag ;
Consola . WriteLine ( " Informar Nome " );
string  var_nome  =  Console . LeiaLinha ();
Consola . WriteLine ( " Informar Endereço " );
string  var_endereco  =  Console . LeiaLinha ();
Consola . WriteLine ( " Pessoa Física (f) ou Jurídica (j) ? " );
string  var_tipo  =  Console . LeiaLinha ();
if ( var_tipo  ==  " f " )
{
// --- Pessoa Física ----
Pessoa_Fisica  pf  =  new  Pessoa_Fisica ();
pf . nome  =  var_nome ;
pf . endereco = var_endereco  ; 
Consola . WriteLine ( " Informar CPF: " );
pf . cpf  =  Console . LeiaLinha ();
Consola . WriteLine ( " Informar RG: " );
pf . rg  =  Console . LeiaLinha ();
Consola . WriteLine ( " Informar Valor de Compra: " );
val_pag  =  float . Analisar ( Console . ReadLine ());
pf . Pagar_Imposto ( val_pag );
Consola . WriteLine ( " -------- Pessoa Física --------- " );
Consola . WriteLine ( " Nome ..........: "  +  pf . nome );
Consola . WriteLine ( " Endereço ......  : " +  pf.endereco ) ;
Consola . WriteLine ( " CPF ...........: "  +  pf . cpf );
Consola . WriteLine ( " RG ............: "  +  pf . rg );
Consola . WriteLine ( " Valor de Compra: "  +
pf . valor . ToString ( " C " ));
Consola . WriteLine ( " Imposto.....: "  +
pf . valor_imposto . ToString ( " C " ));
Consola . WriteLine ( " Total a Pagar: "  +
pf . total . ToString ( " C " ));
}
if ( var_tipo  ==  " j " )
{
}
}
}
}
