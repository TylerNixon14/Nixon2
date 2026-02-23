/********************************************************************
*** NAME : Tyler Nixon
*** CLASS : CSc 346 – Object Oriented Programming
*** ASSIGNMENT : Assignment 2
*** DUE DATE : 02/23/2026
*** INSTRUCTOR : GAMRADT
*********************************************************************
*** DESCRIPTION : This file defines the IView interface for the
***               Viking ADT. Classes implementing IView must provide
***               horizontal and vertical view methods used to display
***               object data in required formats.
********************************************************************/
namespace VikingNS
{
    public interface IView
    {
        void ViewH();
        void ViewV();
    }
}