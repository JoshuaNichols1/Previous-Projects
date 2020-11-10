import greenfoot.*;  // (World, Actor, GreenfootImage, Greenfoot and MouseInfo)

/**
 * Write a description of class Hearts here.
 * 
 * @author (your name) 
 * @version (a version number or a date)
 */
public class Heart1 extends Heart
{
    public Heart1()
    {
        GreenfootImage myImage = getImage();
        int myNewHeight = (int)myImage.getHeight()*2;
        int myNewWidth = (int)myImage.getWidth()*2;
        myImage.scale(myNewWidth, myNewHeight);
    }  
}
