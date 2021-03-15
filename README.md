## Week 5

### Accomplished 
#### Enemy
1. Reduce HP when shooted by *damage bullet*
2. Slow down when shooted by *slowdown bullet*
3. HealthBar
4. There are two types of enemies right now, we could customize the enemy's HP, Speed, and Value

#### Tower & Bullet
1. Customize shooting range. If an enemy enters this range circle，the tower starts to shoot automatically. If the enemy leaves this range circle，the tower stops shooting.
2. Automatically catch the nearest enemy and shoot it
3. There are three types of Tower & Bullet: *damage* tower, *damage plus slowdown* tower, and with damage bonus tower.

#### Player System
1. Each enemy has a value property，when enemy is killed，player money += enemy value
2. When enemy arrives destination，player lives--
3. Player lives and money are displayed on top canvas

#### GameManager
##### WayPoints
Customize route(no change since week4)

##### WaveSpawner
1. Customize number of waves
2. Customize enemy type, number of enemies, and speed of enemies each wave

#### System
Rewrite *Enemy, Tower, Bullet* to inheritance structure, easy to add more types.

