## Capítol 7️⃣ - Decode Ancient Scroll
**Resum de l’enunciat:**  
- Tres sub-opcions:  
  1. Eliminar espais del primer pergamí  
  2. Comptar vocals del segon pergamí  
  3. Extreure números del tercer pergamí  
- Missatge d’èxit quan es completen les 3 tasques.

**Implementació al codi:**  
- Mostra pergamins amb `DecodeOptions`.  
- Llegeix selecció amb validació.  
- Segons opció:  
  - 1 → treu espais del text i mostra resultat  
  - 2 → compta vocals incloses accentuades  
  - 3 → extreu nombres i mostra missatge de decodificació  
- Quan es completen totes → missatge de felicitació.

**Joc de proves**
|#|Categoria|Entrada (introduceNumber)|Lògica de Validació|Variables Clau (Després)|Resultat Esperat|
|:----|:----|:----|:----|:----|:----|
|1|Normal (Opció 1)|1 (Decipher spell)|Entrada vàlida. validInputSeven = TRUE. Executa el case 1 del switch.|scrollOne = true, noEspaces conté la frase sense espais.|Es descodifica el primer missatge (sense espais) i s'actualitza l'estat.|
|2|Normal (Opció 3)|3 (Extract secret code)|Entrada vàlida. Executa el case 3 del switch.|scrollThree = true, onlyNumbers conté els números (5638).|S'extreu el codi secret (els números) i s'actualitza l'estat.|
|3|Límit (Inferior de Sortida)|0|L'opció 0 compleix el rang (0 <= 0 <= 3). validInputSeven = TRUE. El switch no té case 0 i, per tant, no fa res.|Sense canvis.|El bucle while de validació finalitza. No obstant això, el switch no executa cap acció ni surt del menú principal.|
|4|Límit (Superior Opció)|3|Entrada vàlida. Compleix el rang (0 <= 3 <= 3). Executa el case 3 del switch.|scrollThree = true.|Es realitza la descodificació 3.|
|5|Error (Format)|"Text"|Falla en Convert.ToInt32 (FormatException). S'imprimeix ChooseOptionError.|validInputSeven = false|Imprimeix l'error de format i el bucle while es repeteix, sol·licitant l'entrada de nou.|
|6|Error (Rang Alt)|4|Falla la validació de rang (if (4 > 3)). S'imprimeix MessageInputError.|validInputSeven = false|Imprimeix l'error de rang i el bucle while es repeteix, sol·licitant l'entrada de nou.|
