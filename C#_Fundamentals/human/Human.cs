namespace ConsoleApplication {
    public class Human {
        public string name;
        public int strength = 3;
        public int intelligence = 3;
        public int dexterity = 3;
        public int health = 3;
    
        public Human(string n){
            name = n;
        }
        public Human(string n, int stren, int intel, int dext, int hth){
            name = n;
            strength = stren;
            intelligence = intel;
            dexterity = dext;
            health = hth;

        }
        public void Attack(object target){
            Human enemy = target as Human;
            if(enemy != null){
                enemy.health -= 5 * strength;
            }
            
        }

    }

}


