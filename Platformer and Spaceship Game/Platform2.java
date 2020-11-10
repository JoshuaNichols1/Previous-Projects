import greenfoot.*;  // (World, Actor, GreenfootImage, Greenfoot and MouseInfo)

/**
 * Write a description of class Platform2 here.
 * 
 * @author (your name) 
 * @version (a version number or a date)
 */
public class Platform2 extends Platform
{
    public Platform2()
    {
        GreenfootImage myImage = getImage();
        int myNewHeight = (int)myImage.getHeight()*1;
        int myNewWidth = (int)myImage.getWidth()*2;
        myImage.scale(myNewWidth, myNewHeight);
    }     
}
