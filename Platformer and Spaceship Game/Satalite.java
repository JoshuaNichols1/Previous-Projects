import greenfoot.*;  // (World, Actor, GreenfootImage, Greenfoot and MouseInfo)

/**
 * Write a description of class Satalite here.
 * 
 * @author (your name) 
 * @version (a version number or a date)
 */
public class Satalite extends BadGuys
{
    public void act() 
    {
        move();
    }

    public void move() 
    {
        if (this.getX() == 0) {
            getWorld().removeObject(this);
        }
        else {
            super.setLocation(this.getX()-3, this.getY());
        }
    }

    public void hit() 
    {
        getWorld().removeObject(this);
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

    public void isHit() 
    {
        Asteroid asteroid = (Asteroid) getOneIntersectingObject(Asteroid.class);
        if(asteroid != null){
            gameOver();
            hit();
        }
    }

    public void gameOver() {
        Greenfoot.playSound("Lose Sound.mp3");
        GameOver GameOver = new GameOver();
        getWorld().addObject(GameOver,398,300);
        Greenfoot.stop();
    }

    /**
     * Try to eat an object of class 'clss'. This is only successful if there
     * is such an object where we currently are. Otherwise this method does
     * nothing.
     */
    public void take(Class clss)
    {
        Actor actor = getOneObjectAtOffset(0, 0, clss);
        if(actor != null) {
            getWorld().removeObject(actor);
        }
    }
}
