import greenfoot.*;  // (World, Actor, GreenfootImage, Greenfoot and MouseInfo)

/**
 * This is a Crocodile which is trying to eat the Animals
 * 
 * @author Joshua Nichols
 */
public class Crocodile extends Animal
{
    /**
     * This method is the act method
     * 
     * @author Joshua Nichols
     */
    public void act()
    {
        move(5);
        randomTurn();
        turnAtEdge();
        tryToEat();
    }

    /**
     * With a 10% probability, turn a bit right or left.
     * 
     * @author Mik
     */
    public void randomTurn()
    {
        if ( Greenfoot.getRandomNumber(100) < 10 )
        {
            turn( Greenfoot.getRandomNumber(40)-20 );
        }        
    }

    /**
     * If we reach the edge of the world, turn a little bit.
     * 
     * @author Mik
     */
    public void turnAtEdge()
    {
        if (atWorldEdge())
        {
            turn(20);
        }
    }

    /**
     * Check whether we can see Seal and Fish. If we can, eat them.
     * 
     * @author Joshua Nichols
     */
    public void tryToEat()
    {
        if (canSee(Seal.class))
        {
            eat(Seal.class);
            Gameover();
        }
        if (canSee(Fish.class))
        {
            eat(Fish.class);
            Gameover();
        }
    }

    /**
     * When an actor is Eaten its game over
     * 
     * @author Joshua Nichols and Oren Morgan
     */
    public void Gameover()
    {
        GameOver GameOver = new GameOver();
        getWorld().addObject(GameOver,300,200);
        Greenfoot.playSound("game-over.wav");
        Greenfoot.stop();
    }
}
