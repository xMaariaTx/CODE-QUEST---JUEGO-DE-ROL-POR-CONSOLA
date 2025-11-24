## Capítol 1️⃣ - Train Your Wizard

**Objectiu:** Entrenar el mag i assignar un títol segons els punts de poder acumulats.  

**Funcionament:**
- Sol·licita el nom del mag i capitalitza la primera lletra.
- Simula 5 dies d’entrenament:
  - Genera hores aleatòries (1–24)
  - Genera punts de poder aleatoris (1–10)
- Després dels 5 dies, assigna un títol/rang segons els punts totals:

| Punts | Títol | Missatge |
|-------|-------|----------|
| <20 | Raoden el Elantri | Repeteixes a 2a convocatòria |
| 20–29 | Zyn el Buguejat | Encara confons la vareta amb una cullera |
| 30–34 | Arka Nullpointer | Ets un Invocador de Brises Màgiques |
| 35–39 | Elarion de les Brases | Uau! Pots invocar dracs sense cremar el laboratori |
| ≥40 | ITB-Wizard el Gris | Has assolit el rang de Mestre dels Arcans |

**Implementació al codi:**  
- Es llegeix el nom amb `Console.ReadLine()` i es capitalitza la primera lletra.  
- Bucle `for` de 1 a 5 dies, generant hores i punts amb `Random.Next()`.  
- Assignació de títol amb `switch` depenent del `inicial_level`.  
- Mostra missatge final amb nom, punts totals i títol.

**Joc de proves**
|#|Categoria|Entrada (tempName)|Variables Clau (Abans)|Condició/Lògica|Variables Clau (Després)|Resultat Esperat|
|:----|:----|:----|:----|:----|:----|:----|
|1|Normal (Minúscules)|"gandalf"|tempName = ""|Es converteix a minúscules: "gandalf". Es capitalitza la primera lletra.|name = "Gandalf"|El nom es mostra correctament capitalitzat (Gandalf) al missatge d'entrenament.|
|2|Normal (Majúscules)|"MERLIN"|tempName = ""|Es converteix a minúscules: "merlin". Es capitalitza la primera lletra.|name = "Merlin"|El nom es mostra correctament capitalitzat (Merlin) al missatge d'entrenament.|
|3|Normal (Combinada)|"aRKa"|tempName = ""|Es converteix a minúscules: "arka". Es capitalitza la primera lletra.|name = "Arka"|El nom es mostra correctament capitalitzat (Arka).|
|---|---|---|---|---|---|---|
|4|Límit (1 caràcter)|"z"|tempName = ""|Es converteix a minúscules: "z". Substring(1, 0) retorna una cadena buida. Es capitalitza la primera lletra.|name = "Z"|El nom es mostra com un sol caràcter capitalitzat (Z).|
|5|Límit (Cadena llarga)|"eldrynnasdasd..."|tempName = ""|Es processa sense problemes, independentment de la longitud.|name = "Eldrynnasdasd..."|El nom es mostra capitalitzat, gestionant la longitud.|
|---|---|---|---|---|---|---|
|6|Error (Cadena buida)|"" (L'usuari prem Enter sense escriure res)|tempName = ""|tempName és una cadena buida, no és null. El codi intenta: Substring(0, 1) (falla si la longitud és 0) i Substring(1, -1) (falla si la longitud és 0).|Error: ArgumentOutOfRangeException (error de temps d'execució) a Substring (el codi no gestiona correctament una cadena buida).|Resultat real: El programa crashtja en intentar fer Substring(0, 1) i Substring(1, length-1) amb una longitud de 0. Nota: La gestió de tempName == null és insuficient; hauria d'incloure string.IsNullOrEmpty(tempName).|
|7|Error (Valor Nul)|null (Valor que rep si ReadLine és forçat a retornar nul)|tempName = ""|if (tempName == null) és TRUE. tempName s'estableix a "Default".|name = "Default"|El nom s'estableix com a "Default" i l'entrenament continua. (El codi només gestiona aquest cas d'error).|
