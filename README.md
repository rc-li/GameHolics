## Week 5 Progress
### Accomplished 
#### Enemy
1. reduce HP when shooted by *damage bullet*
2. slow down when shooted by *slowdown bullet*
3. healthBar
4. there are two types of enemies right now, we could customize the enemy's HP, Speed, and Value

#### Tower & Bullet
1. customize shooting range. If an enemy enters this range circle，the tower starts to shoot automatically. If the enemy leaves this range circle，the tower stops shooting.
2. automatically catch the nearest enemy and shoot it
3. there are two types of Tower & Bullet, one is *damage* tower and the other is *damage plus slowdown* tower

#### Player System
1. each enemy has a value property，when enemy is killed，player money += enemy value
2. when enemy arrives destination，player lives--
3. player lives and money are displayed on top canvas

#### GameManager
##### WayPoints
customize route(no change since week4)

##### WaveSpawner
1. customize number of waves
2. customize enemy type, number of enemies, and speed of enemies each wave

#### System
Rewrite *Enemy, Tower, Bullet* to inheritance structure, easy to add more types.
