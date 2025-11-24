## Capítol 2️⃣ - Increase LVL (Combat amb daus)

**Objectiu:** Combatir un monstre per pujar de nivell.  

**Funcionament:**
- Apareix un monstre aleatori amb HP determinat.  
- El jugador tira un dau (1–6) per atacar.
- Cada tirada resta HP al monstre i mostra un ASCII art del dau.
- Quan HP = 0, el jugador puja de nivell (màx. 5).

**Implementació al codi:**  
- Selecció aleatòria del monstre i HP amb `Random.Next()`.  
- Bucle `while` fins a que `liveMonsters` = 0:  
  - Tirada de dau aleatòria (`Random.Next(0,6)`)  
  - Mostra ASCII art corresponent (`rollDice[dice]`)  
  - Resta HP del monstre i mostra missatge  
  - `Console.ReadKey()` per pausar entre tirades  
- Quan el monstre és derrotat, incrementa `levelWizard`.

**Joc de proves**
