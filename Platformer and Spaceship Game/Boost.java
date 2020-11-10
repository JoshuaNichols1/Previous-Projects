import greenfoot.*;  // (World, Actor, GreenfootImage, Greenfoot and MouseInfo)

/**
 * Write a description of class Boost here.
 * 
 * @author (your name) 
 * @version (a version number or a date)
 */
public class Boost extends Interactives
{
    public void act() 
    {
        move();
    }

    public void move() 
    {
        if (this.getY() == 0) {
            getWorld().removeObject(this);
        }
        else 
        {
            super.setLocation(this.getX(), this.getY()-1);
        }
    }

    public Boost()
    {
        GreenfootImage myImage = getImage();
        int myNewHeight = (int)myImage.getHeight()*3;
        int myNewWidth = (int)myImage.getWidth()*3;
        myImage.scale(myNewWidth, myNewHeight);
    }
}
