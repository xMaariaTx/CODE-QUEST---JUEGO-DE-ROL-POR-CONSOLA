## Capítol 6️⃣ - Show Attacks by LVL
**Resum de l’enunciat:**  
- Mostra els atacs disponibles segons el nivell actual del mag.

**Implementació al codi:**  
- Utilitza `attacksuser`, un array de arrays (jagged array).  
- Imprimeix els atacs corresponents a `levelWizard`.  
- Mostra missatge motivador per seguir entrenant.

**Joc de proves**
|#|Categoria|Variables Clau (Abans)|Lògica/Condició Provada|Variables Clau (Després)|Resultat Esperat|
|:----|:----|:----|:----|:----|:----|
|1|Normal (Nivell Inicial)|levelWizard = 1|S'accedeix a attacksuser[0]. S'imprimeixen els atacs del Nivell 1 ("Magic Spark 💫").|Sense canvis.|Es mostren els atacs de Nivell 1.|
|2|Normal (Nivell Intermedi)|levelWizard = 3|S'accedeix a attacksuser[2]. S'imprimeixen els atacs del Nivell 3 (Meteor, Pure Energy Explosion, etc.).|Sense canvis.|Es mostren els atacs corresponents al Nivell 3.|
|3|Límit (Nivell Màxim)|levelWizard = 5|S'accedeix a attacksuser[4]. S'imprimeixen els atacs del Nivell 5.|Sense canvis.|Es mostren tots els atacs del Nivell 5.|
|4|Error (Nivell Fora de Rang)|levelWizard = 0 (Valor impossible, assumint que l'inicial és 1)|S'intenta accedir a attacksuser[levelWizard - 1], que seria attacksuser[-1].|Error d'Execució (IndexOutOfRangeException).|El programa crashea ja que es trenca el límit inferior de l'array.|
|5|Error (Nivell Existent però Fora de la Lògica)|levelWizard = 6 (Valor que podria obtenir-se si la lògica del case 2 no tingués limitació)|S'intenta accedir a attacksuser[levelWizard - 1], que seria attacksuser[5].|Error d'Execució (IndexOutOfRangeException).|El programa crashea ja que es trenca el límit superior de l'array (attacksuser només té 5 files, índexs 0-4).|
