import greenfoot.*;  // (World, Actor, GreenfootImage, Greenfoot and MouseInfo)

/**
 * Write a description of class Fuel2 here.
 * 
 * @author (your name) 
 * @version (a version number or a date)
 */
public class Fuel2 extends Interactives
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
}
