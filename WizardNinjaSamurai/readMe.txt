{*}Create a class for a Ninja, a Wizard, and a Samurai. For this assignment, you will need to modify your Human class.

    - 1. Wizard should have a default health of 50 and Intelligence of 25
    
    - 2. Ninja should have a default dexterity of 175
    
    - 3. Samurai should have a default health of 200
    
    - 4. Provide an override Attack method to Wizard, which reduces the target by 5 * Intelligence and heals the Wizard by the amount of damage dealt
    
    - 5. Provide an override Attack method to Ninja, which reduces the target by 5 * Dexterity and a 20% chance of dealing an additional 10 points of damage.
    
    - 6. Provide an override Attack method to Samurai, which calls the base Attack and reduces the target to 0 if it has less than 50 remaining health points.
    
    - 7. Wizard should have a method called Heal, which when invoked, heals a target Human by 10 * Intelligence
    
    - 8. Samurai should have a method called Meditate, which when invoked, heals the Samurai back to full health
    
    - 9. Ninja should have a method called Steal, reduces a target Human's health by 5 and adds this amount to its own health.