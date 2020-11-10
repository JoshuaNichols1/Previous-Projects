import greenfoot.*;  // (World, Actor, GreenfootImage, Greenfoot and MouseInfo)

/**
 * This is a Seal which is running away from the crocodile
 * 
 * @author Joshua Nichols
 */
public class Seal extends Animal
{
    private int points = 0;
    private Counter counter;

    /**
     * This method is to link the counter to the Seal
     * 
     * @author Michael Kšlling
     */
    public Seal(Counter pointCounter)
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
     * 
     * @author Michael Kšlling
     */
    public void checkKeys()
    {
        if ( Greenfoot.isKeyDown("left") )
        {
            turn(-5);
        }
        if ( Greenfoot.isKeyDown("right") )
        {
            turn(5);
        }
    }

    /**
     * Check whether we can see Apple. If we can, eat it.
     * 
     * @author Joshua Nichols
     */
    public void tryToEat()
    {
        if (canSee(Apple.class) )
        {
            eat(Apple.class);
            counter.add(15);
            Greenfoot.playSound("apple.wav");
            createNewApple();
        }
        if (counter.getValue() >= 80) 
        {
            YouWin();
        }
    }

    /**
     * Create a new Apple and insert it at a random location in the world.
     * 
     * @author Michael Kšlling
     */
    private void createNewApple()
    {
        Apple newApple;
        newApple = new Apple();

        World world;
        world = getWorld();

        int worldWidth = world.getWidth();
        int worldHeight = world.getHeight();

        int x = Greenfoot.getRandomNumber(worldWidth);
        int y = Greenfoot.getRandomNumber(worldHeight);

        world.addObject(newApple, x, y);
    }

    /**
     * We have won the game.
     * 
     * @author Joshua Nichols and Oren Morgan
     */
    public void YouWin()
    {
        YouWin YouWin = new YouWin();
        getWorld().addObject(YouWin,300,200);
        Greenfoot.playSound("fanfare.wav");
        Greenfoot.stop();
    }
}
