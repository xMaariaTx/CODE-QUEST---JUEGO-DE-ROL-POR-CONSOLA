# 🧱 BLOC1.PA03 - CODEQUEST DLC

## ⚙️ Requisitos del Proyecto
- Todos los códigos deben incluir **control de errores**.
- La codificación debe estar en **inglés** (mensajes, comentarios, variables, constantes).
- Cada capítulo debe definir un **juego de pruebas** para el debug.
- Se deben gestionar **issues** y **Pull Requests (PR)** por cada capítulo.
- El repositorio debe incluir un **README con Markdown** que describa el proyecto y el juego de pruebas.

# ACTIVIDAD: CODEQUEST - JUEGO DE ROL POR CONSOLA
  
## 📜 Descripción General
**CodeQuest** es un RPG de consola desarrollado en **C#**, donde el jugador controla a un mago capaz de:
- Entrenar para aumentar su nivel.
- Combatir monstruos y ganar experiencia.
- Minar recursos (*bits*, la moneda del juego).
- Comprar objetos para mejorar su inventario.
- Descubrir y resolver pergaminos antiguos.
  
El juego cuenta con un **menú principal de 7 opciones** + la opción de salir.  
Cada capítulo está implementado en una rama específica:
- `chapter/trainwizard`
- `chapter/increaselvl`
- `chapter/lootthemine`
- `chapter/showinventory`
- `chapter/buyitems`
- `chapter/showattacks`
- `chapter/decodescroll`

## 🕹️ Menú Principal
El menú se mostrará repetidamente hasta que el usuario elija salir:  

===== MAIN MENU - CODEQUEST =====  
===== Welcome, [NOMBRE] the [TÍTULO] with level [NIVEL] =====  
Train your wizard - Entrenar al mago  
Increase LVL - Combatir y subir de nivel  
Loot the mine - Minar para conseguir bits (moneda del juego)  
Show inventory - Mostrar inventario  
Buy items - Comprar objetos  
Show attacks by LVL - Ver ataques disponibles según el nivel  
Decode ancient Scroll - Descifrar pergaminos mágicos  
Exit game - Salir  


## 🔧 Funcionalidades por Opción

### 0️⃣ Caso Main Juego de Pruebas
|#|Categoría|Entrada (op)|Variables Clave (Antes)|Condición/Lógica|Variables Clave (Después)|Resultado Esperado|
|:----|:----|:----|:----|:----|:----|:----|
|1|Normal|1 (Train wizard)|op=0, validInput=true|try-catch es exitoso. switch ejecuta case 1.|op=1, validInput=true|Ejecuta el caso 1 (Entrenamiento). El bucle continúa.|
|2|Normal|4 (Show inventory)|op=1, validInput=true|try-catch es exitoso. switch ejecuta case 4.|op=4, validInput=true|Ejecuta el caso 4 (Inventario). El bucle continúa.|
|3|Normal|7 (Decode Scroll)|op=4, validInput=true|try-catch es exitoso. switch ejecuta case 7.|op=7, validInput=true|Ejecuta el caso 7 (Decodificación). El bucle continúa.|
|---|---|---|---|---|---|---|
|4|Límite (Salida)|0 (Exit Game)|op=7, validInput=true|try-catch es exitoso. switch ejecuta case 0. Condición op != 0 es FALSE.|op=0, validInput=true|El juego sale del bucle principal (do-while).|
|5|Límite (Superior)|7|op=0, validInput=true|try-catch es exitoso. switch ejecuta case 7.|op=7, validInput=true|Ejecuta el caso 7. El bucle continúa.|
|---|---|---|---|---|---|---|
|6|Error (Fuera de Rango)|8|op=7, validInput=true|try-catch es exitoso. switch ejecuta el default (implícito).|op=8, validInput=true|Repite el menú sin ejecutar acción, ya que op != 0 es TRUE.|
|7|Error (Formato - Texto)|"A"|op=8, validInput=true|Falla en Convert.ToInt32 (FormatException). Se atrapa error, imprime ChooseOptionError y validInput = false.|op=8 (mantiene anterior), validInput=false|Imprime mensaje de error y repite el menú.|
|8|Error (Formato - Decimal)|3.5|op=8, validInput=false|Falla en Convert.ToInt32 (FormatException). Se atrapa error y se establece validInput = false.|op=8 (mantiene anterior), validInput=false|Imprime mensaje de error y repite el menú.|


### 1️⃣ Train your wizard
- Pide el **nombre del mago** y lo capitaliza.
- Simula **5 días de entrenamiento** generando:
  - Horas de entrenamiento (1–24)
  - Puntos de poder (1–10)
- Según el total acumulado, asigna un **título**:

| Puntos de Poder | Título | Mensaje |
|----------------|-------|----------|
| < 20 | Raoden el Elantrino | Repites en 2ª convocatoria. |
| 20-29 | Zyn el Bugeado | Aún confundes la varita con una cuchara. |
| 30-34 | Arka Nullpointer | Eres un Invocador de Brisas Mágicas. |
| 35-39 | Elarion de las Brasas | ¡Uau! ¡Puedes invocar dragones sin quemar el laboratorio! |
| ≥ 40 | ITB-Wizard el Gris | ¡Has alcanzado el rango de Maestro de los Arcanos! |

---

### 2️⃣ Increase LVL (Combate con dados)
- Aparece un **monstruo aleatorio** con HP específicos.
- El jugador tira un dado (1–6) con ASCII art.
- El resultado = daño infligido al monstruo.
- Si el monstruo llega a 0 HP → **el jugador sube de nivel** (hasta 5).

| Monstruo | HP |
|---------|----|
| Wandering Skeleton 💀 | 3 |
| Forest Goblin 👹 | 5 |
| Green Slime 🟢 | 10 |
| Ember Wolf 🐺 | 11 |
| Giant Spider 🕷️ | 18 |
| Iron Golem 🤖 | 15 |
| Lost Necromancer 🧝‍♂️ | 20 |
| Ancient Dragon 🐉 | 50 |

---

### 3️⃣ Loot the mine (Minería)
- Matriz **5x5** inicialmente vacía.
- Jugador con **5 intentos**.
- Introducción de coordenadas X e Y.
- Si acierta una posición con moneda: → gana entre **5 y 50 bits**.
  - `➖` = No excavado  
  - `🪙` = Moneda encontrada  
  - `❌` = Excavación sin éxito

---

### 4️⃣ Show inventory
- Mostra los objetos comprados.
- Si está vacío → informa al usuario.

---

### 5️⃣ Buy items
- Muestra objetos disponibles y precios.  
- Compra si tiene suficientes bits y se actualiza el inventario.

| Objeto | Precio (bits) |
|---------|-------------|
| Iron Dagger 🗡️ | 30 |
| Healing Potion ⚗️ | 10 |
| Ancient Key 🗝️ | 50 |
| Crossbow 🏹 | 40 |
| Metal Shield 🛡️ | 20 |

- Si el jugador tiene suficientes bits:
  - Se descuenta el precio.
  - Se añade el producto al inventario (array ampliable).

 ---

### 6️⃣ Show attacks by LVL
- Muestra los ataques disponibles según el nivel del mago:

| Nivel | Ataques |
|--------|-------|
| 1 | Magic Spark 💫 |
| 2 | Fireball 🔥, Ice Ray 🥏, Arcane Shield ⚕️ |
| 3 | Meteor ☄️, Pure Energy Explosion 💥, Minor Charm 🎭, Air Strike 🍃 |
| 4 | Wave of Light ⚜️, Storm of Wings 🐦 |
| 5 | Cataclysm 🌋, Portal of Chaos 🌀, Arcane Blood Pact 🩸, Elemental Storm ⛈️ |

---

### 7️⃣ Decode ancient Scroll
- Tres sub-opciones:
  1. Eliminar espacios del primer pergamino.
  2. Contar vocales (incluidas acentuadas) del segundo pergamino.
  3. Extraer números del tercer pergamino.
- Cuando se completan, muestra mensaje de éxito.

---

## 📦 Arrays Fijos
- **Objetos para comprar:** Iron Dagger 🗡️, Healing Potion ⚗️, Ancient Key 🗝️, Crossbow 🏹, Metal Shield 🛡️  
- **Monstruos:** Wandering Skeleton 💀, Forest Goblin 👹, Green Slime 🟢, Ember Wolf 🐺, Giant Spider 🕷️, Iron Golem 🤖, Lost Necromancer 🧝‍♂️, Ancient Dragon 🐉  
- **Atasques por nivel:** ver tabla de la opción 6.
  
## 🧩 Retos Opcionales
- Guardar y cargar partidas utilizando ficheros.
- Sistema de combate más complejo: el monstruo también ataca, los ataques tienen coste de poder.
- Objetos con efecto en el combate.
- Tienda con objetos variables según el nivel del mago.
- Uso de colores en la consola.
- Sistema de misiones con recompensas.

## ✨ Conclusión
**CodeQuest** es un proyecto completo que combina estructuras de control, arrays, validación de errores y organización por ramas, todo dentro de un juego de consola entretenido y ampliable.
