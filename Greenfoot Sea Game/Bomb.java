import greenfoot.*;  // (World, Actor, GreenfootImage, Greenfoot and MouseInfo)

/**
 * A bomb that tries to blow up Actors
 * 
 * @author Joshua Nichols
 */
public class Bomb extends Actor
{
    /**
     * Test if we are close to one of the edges of the world. Return true is we are.
     */
    public boolean atWorldEdge()
    {
        if(getX() < 10 || getX() > getWorld().getWidth() - 10)
            return true;
        if(getY() < 10 || getY() > getWorld().getHeight() - 10)
            return true;
        else
            return false;
    }

    /**
     * Return true if we can see an object of class 'clss' right where we are. 
     * False if there is no such object here.
     */
    public boolean canSee(Class clss)
    {
        Actor actor = getOneObjectAtOffset(0, 0, clss);
        return actor != null;        
    }

    /**
     * Try to eat an object of class 'clss'. This is only successful if there
     * is such an object where we currently are. Otherwise this method does
     * nothing.
     */
    public void destroy(Class clss)
    {
        Actor actor = getOneObjectAtOffset(0, 0, clss);
        if(actor != null) {
            getWorld().removeObject(actor);
        }
    }

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
        tryToDestroy();
    }

    /**
     * With a 10% probability, turn a bit right or left.
     * 
     * @author Michael Kšlling
     */
    public void randomTurn()
    {
        if ( Greenfoot.getRandomNumber(100) < 20 )
        {
            turn( Greenfoot.getRandomNumber(100)-50 );
        }        
    }

    /**
     * If we reach the edge of the world, turn a little bit.
     * 
     * @author Michael Kšlling
     */
    public void turnAtEdge()
    {
        if (atWorldEdge())
        {
            turn(15);
        }
    }

    /**
     * Check whether we can see Seal and Fish. If we can, eat them.
     * 
     * @author Joshua Nichols
     */
    public void tryToDestroy()
    {
        if (canSee(Seal.class))
        {
            destroy(Seal.class);
            Gameover();
        }
        if (canSee(Fish.class))
        {
            destroy(Fish.class);
            Gameover();
        }
    }

    /**
     * When an actor is blown up its game over
     * 
     * @author Joshua Nichols and Oren Morgan
     */
    public void Gameover()
    {
        GameOver GameOver = new GameOver();
        getWorld().addObject(GameOver,300,200);   
        Greenfoot.playSound("bomb.wav");
        Greenfoot.stop();
    }
}
