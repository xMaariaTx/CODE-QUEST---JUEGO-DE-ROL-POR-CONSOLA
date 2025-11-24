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
