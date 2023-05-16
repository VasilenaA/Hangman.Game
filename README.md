# Hangman.Game
I had a task to make the game " hangman" as a course project.
In Bulgarian it is called "Бесеница"(Besenica)

Тhe requirement that was given to me-
To develop an app that mimics the game Hangman. The application to contain the following functionality:
- a form to add new words and categories and delete existing ones existing
- a main form in which the user will be able to play where a score should be counted
- individual options to be separated in a menu

- so my idea was to create a main form (Form1), from which I could access the other two forms- the one for adding and removing words and categories (WordCorrectionForm) and the game itself (MainGameForm). I created 2 classes Category and Word.
-  Then in the first form I created some "default" categories and words to them.
-   In the edit form, to add a word, the user has to select which category they want to add it to, similar for the rubric. When he wants to add a new category, he must also add a word to it so it is not empty. Accordingly, when he deletes a category, all words belonging to it are also deleted.
-   In the game form, one first chooses which category one wants to play in and then a word is randomly assigned. When the user guesses the word he gets one point and so until he makes a mistake his score is reset to zero. With pictures and number of bytes remaining, the process of " hanging" is represented.
-   And for the condition that the individual options are separated in a menu, I made a menuStrip with the options to access the other form and exit the application respectively
