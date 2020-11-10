import greenfoot.*;  // (World, Actor, GreenfootImage, Greenfoot and MouseInfo)

/**
 * Write a description of class Rules here.
 * 
 * @author (your name) 
 * @version (a version number or a date)
 */
public class Rules extends Screens
{
    public void act()
    {
        if ( Greenfoot.isKeyDown("enter") )
        {
            getWorld().removeObject(this);
        }
    }  
}
