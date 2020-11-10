import greenfoot.*;  // (World, Actor, GreenfootImage, Greenfoot and MouseInfo)

/**
 * Write a description of class Heart4 here.
 * 
 * @author (your name) 
 * @version (a version number or a date)
 */
public class Heart4 extends Heart
{
    public Heart4()
    {
        GreenfootImage myImage = getImage();
        int myNewHeight = (int)myImage.getHeight()*2;
        int myNewWidth = (int)myImage.getWidth()*2;
        myImage.scale(myNewWidth, myNewHeight);
    }   
}
