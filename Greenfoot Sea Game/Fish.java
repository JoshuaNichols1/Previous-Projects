import greenfoot.*;  // (World, Actor, GreenfootImage, Greenfoot and MouseInfo)

/**
 * This is a Fish which is running away from the crocodile
 * 
 * @author Joshua Nichols
 */
public class Fish extends Animal
{
    private int points = 0;
    private Counter counter;    
    /**
     * This method is to link the counter to the fish
     * 
     * @author  Michael Kšlling
     */
    public Fish(Counter pointCounter)
    {
        counter = pointCounter;
    }

    /**
     * This method is the act method
     * 
     * @author Joshua Nichols
     */
    public void act()
    {
        move(4);
        checkKeys();
        tryToEat();
    }

    /**
     * Check whether the control keys are being pressed, and turn
     * if they are.
     * @author Michael Kšlling
     * 
     */
    public void checkKeys()
    {
        if ( Greenfoot.isKeyDown("a") )
        {
            turn(-5);
        }
        if ( Greenfoot.isKeyDown("d") )
        {
            turn(5);
        }
    }

    /**
     * Check whether we can see Leaf. If we can, eat it.
     * 
     * @author Joshua Nichols
     */
    public void tryToEat()
    {
        if (canSee(Leaf.class))
        {
            eat(Leaf.class);
            counter.add(15);
            Greenfoot.playSound("slurp.wav");
            createNewLeaf();
        }
        if (counter.getValue() >= 80) 
        {
            YouWin();
        }
    }

    /**
     * Create a new Leaf and insert it at a random location in the world.
     * 
     * @author Michael Kšlling
     */
    private void createNewLeaf()
    {
        Leaf newLeaf;
        newLeaf = new Leaf();

        World world;
        world = getWorld();

        int worldWidth = world.getWidth();
        int worldHeight = world.getHeight();

        int x = Greenfoot.getRandomNumber(worldWidth);
        int y = Greenfoot.getRandomNumber(worldHeight);

        world.addObject(newLeaf, x, y);
    }

    /**
     * We have won the game.
     * 
     * @author Oren Morgan and Joshua Nichols
     */
    public void YouWin()
    {
        YouWin YouWin = new YouWin();
        getWorld().addObject(YouWin,300,200);
        Greenfoot.playSound("fanfare.wav");
        Greenfoot.stop();
    }
}
