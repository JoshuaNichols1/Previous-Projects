import greenfoot.*;  // (World, Actor, GreenfootImage, Greenfoot and MouseInfo)

/**
 * The Great open Sea where our animals can live in.
 * 
 * @author Joshua Nichols
 */
public class Sea extends World
{
    /**
     * Create the turtle world. Our world has a size 
     * of 560x460 cells, where every cell is just 1 pixel.
     */
    public Sea() 
    {
        super(600, 480, 1);
        prepare();
    }

    /**
     * Prepare the world for the start of the program. That is: create the initial
     * objects and add them to the world.
     */
    private void prepare()
    {
        Counter counter = new Counter();
        addObject(counter, 58, 26);

        Fish fish = new Fish(counter);
        addObject(fish,58,231);
        Seal seal = new Seal(counter);
        addObject(seal,58,231);
        Apple Apple = new Apple();
        addObject(Apple, 419, 106);
        Apple Apple2 = new Apple();
        addObject(Apple2, 517, 210);
        Apple Apple3 = new Apple();
        addObject(Apple3, 529, 379);
        Apple Apple4 = new Apple();
        addObject(Apple4, 330, 426);
        Apple Apple5 = new Apple();
        addObject(Apple5, 405, 294);
        Apple Apple6 = new Apple();
        addObject(Apple6, 243, 61);
        Apple Apple7 = new Apple();
        addObject(Apple7, 103, 70);
        Apple Apple8 = new Apple();
        addObject(Apple8, 68, 335);
        Apple Apple9 = new Apple();
        addObject(Apple9, 218, 312);
        Crocodile Crocodile = new Crocodile();
        addObject(Crocodile, 456, 73);
        Leaf Leaf = new Leaf();
        addObject(Leaf, 361, 159);
        Leaf Leaf2 = new Leaf();
        addObject(Leaf2, 222, 402);
        Leaf leaf3 = new Leaf();
        addObject(leaf3,282,251);
        Leaf leaf4 = new Leaf();
        addObject(leaf4,52,256);
        Leaf leaf5 = new Leaf();
        addObject(leaf5,45,69);
        Leaf leaf6 = new Leaf();
        addObject(leaf6,387,25);
        Leaf leaf7 = new Leaf();
        addObject(leaf7,427,444);
        Leaf leaf8 = new Leaf();
        addObject(leaf8,119,459);
        Leaf leaf9 = new Leaf();
        addObject(leaf9,546,146);
        fish.setLocation(364,363);
        seal.setLocation(167,158);
        Bomb bomb = new Bomb();
        addObject(bomb,153,370);
        Bomb bomb2 = new Bomb();
        addObject(bomb2,570,228);
        removeObject(bomb2);
        GameOver gameOver = new GameOver();
        addObject(gameOver,310,262);
        gameOver.setLocation(324,327);
        removeObject(gameOver);
    }
}
