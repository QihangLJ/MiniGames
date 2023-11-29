using System;

namespace Practica2
{
    class HangmanGame
    {
        public static void Main()
        {
            const string msgWelcome = "         **************************************************** \n" +
                                      "         ***************Bienvenid@ AL AHORCADO*************** \n" +
                                      "         ****************************************************";
            const string msgChooseDifficulty = "Please, choose the level of the difficulty:";
            const string msgLevel = "A. Easy \nB. Normal \nC. Difficult \nD. Expert";
            const string msgInvalidValue = "The value is not valid. Please choose a valid value:";
            const string msgYouChoose = "The difficulty that you has chosen is";
            const string msgPressContinue = "Press any buttom tho continue...";
            const string msgWriteText = "Write a text: ";
            const string msgYourAttempts = "Number of attempts remaining:";
            const string msgYourGuessed = "Number of guessed character:";
            const string msgWriteChar = "Write one letter (consonant or vocal) in CAPITAL LETTER:";
            const string msgWordReveal = "The word was:";
            const string msgWin = "Congratulations! You have won!";
            const string msgLose = "You have finished the number of attempts! \nGAME OVER!";

            const char lowBar = '_', centerBar = '-';

            const int OFFSET = 1, valueZero = 0, alphabetLimite = 9, HALF = 2;
            const int levelEasy = 7, levelNormal = 5, levelDifficult = 4, levelExpert = 3,
                      lengthEasy = 4, lengthNormal = 6, lengthDifficult = 8, lengthExpert = 10;

            char[] charArrayAlphabet = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'Ñ', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            char[,] charMatrixDraw = {{ '+', '=', '=', '=', '=', '=', '=', '+', ' ', ' ' },
                                      { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' },
                                      { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' },
                                      { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' },
                                      { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' },
                                      { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' },
                                      { '=', '=', '=', '=', '=', '=', '=', '=', '=', '=' } };
            string intputText, selectedWord = " ";
            char levelSelect, intputChar;
            int attempts = 0, guessed = 0, wordLength = 0;
            bool exitLoop = false;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(msgWelcome + "\n");
            Console.ResetColor();

            Console.WriteLine(msgChooseDifficulty + "\n");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(msgLevel + "\n");
            Console.ResetColor();
            do
            {
                levelSelect = Convert.ToChar(Console.ReadLine());
                levelSelect = Char.ToUpper(levelSelect);
                exitLoop = true;
                if (levelSelect != 'A' && levelSelect != 'B' && levelSelect != 'C' && levelSelect != 'D')
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(msgInvalidValue);
                    Console.ResetColor();
                    exitLoop = false;
                }
            } while (!exitLoop);

            Console.WriteLine(levelSelect == 'A' ? $"{msgYouChoose} EASY!" :
                              levelSelect == 'B' ? $"{msgYouChoose} NORMAL!" :
                              levelSelect == 'C' ? $"{msgYouChoose} DIFFICULT!" : $"{msgYouChoose} EXPERT!");

            Console.WriteLine(msgPressContinue);
            Console.ReadLine();
            Console.Clear(); //We cleared the console sreen

            Console.WriteLine(msgWriteText + "\n");
            intputText = Console.ReadLine();
            string[] stringArrayText = intputText.Split(' '); //We convert the string to an array of string.
            Console.Clear(); //We cleared the console sreen

            switch (levelSelect)
            {
                case 'A':
                    attempts = levelEasy;
                    wordLength = lengthEasy;
                    break;
                case 'B':
                    attempts = levelNormal;
                    wordLength = lengthNormal;
                    break;
                case 'C':
                    attempts = levelDifficult;
                    wordLength = lengthDifficult;
                    break;
                case 'D':
                    attempts = levelExpert;
                    wordLength = lengthExpert;
                    break;
            }

            char methodSelection = stringArrayText.Length % HALF == valueZero ? '+' : '-'; //We will use this variable to choose between two methods for select the word. 

            while (selectedWord == " ") //We will exit the loop when we have the the secret word
            {
                if (methodSelection == '+')
                {
                    //1st Method: Starting to read words from the first word.
                    for (int i = 0; i < stringArrayText.Length; i++)
                    {
                        if (stringArrayText[i].Length == wordLength)
                        {
                            selectedWord = stringArrayText[i].ToUpper(); //We will work with Capital Letter.
                        }
                    }
                }
                else
                {
                    //2nd Method: Starting to read words from the last word.
                    for (int i = stringArrayText.Length - OFFSET; i >= 0; i--)
                    {
                        if (stringArrayText[i].Length == wordLength)
                        {
                            selectedWord = stringArrayText[i].ToUpper(); //We will work with Capital Letter.
                        }
                    }
                }
                wordLength--; //If the text don't have the word with the length that we want, it will decrease 1 digit.
                
                if(wordLength == 0) //If all the word are bigger than the difficult that we select, the machine will select the word in the middle of the text.
                {
                    selectedWord = stringArrayText[stringArrayText.Length / HALF].ToUpper();
                }
            }

            //Clean the secret word if it have accents.
            char[] wordClear = selectedWord.ToCharArray();
            for (int i = 0; i< selectedWord.Length; i++)
            {
                if (selectedWord[i] == 'Á' || selectedWord[i] == 'À')
                {
                    wordClear[i] = 'A';
                }
                else if (selectedWord[i] == 'É' || selectedWord[i] == 'È')
                {
                    wordClear[i] = 'E';
                }
                else if(selectedWord[i] == 'Í' || selectedWord[i] == 'Ì')
                {
                    wordClear[i] = 'I';
                }
                else if(selectedWord[i] == 'Ó' || selectedWord[i] == 'Ò')
                {
                    wordClear[i] = 'O';
                }
                else if(selectedWord[i] == 'Ú' || selectedWord[i] == 'Ù')
                {
                    wordClear[i] = 'U';
                }
                else
                {
                    wordClear[i] = selectedWord[i];
                }
            }

            //We replace the character of the word with lowBar = '_'. 
            char[] selectedWordIncognit = new char [wordClear.Length];
            for (int i = 0; i < wordClear.Length; i++)
            {
                selectedWordIncognit[i] = lowBar;
            }

            //Start point of the game loop, where the screen will reset when the user put some intput.
            bool exitGame = false;
            do
            {
                //Show the number of attempts that we have and the guessed character.
                Console.WriteLine(msgYourAttempts + " " + attempts);
                Console.WriteLine(msgYourGuessed + " " + guessed + "\n");

                //Show all the alphabet.
                for (int i = 0; i < charArrayAlphabet.Length; i++)
                {
                    if (charArrayAlphabet[i] == lowBar)
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    if (charArrayAlphabet[i] == centerBar)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Red;
                    }

                    Console.Write(charArrayAlphabet[i] + " ");
                    Console.ResetColor();
                    if ((i + OFFSET) % alphabetLimite == valueZero)
                        Console.WriteLine();
                }
                Console.WriteLine();

                //Show the lowBar as long as the word.
                foreach (char c in selectedWordIncognit)
                {
                    Console.Write(c + " ");
                }
                Console.WriteLine("\n");

                //Show the draw of the hangman game.
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Cyan;
                for (int i = 0; i < charMatrixDraw.GetLength(0); i++)
                {
                    for (int j = 0; j < charMatrixDraw.GetLength(1); j++)
                    {
                        Console.Write(charMatrixDraw[i, j]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.ResetColor();

                //Ask player to write some character (alphabet letter).
                Console.WriteLine(msgWriteChar);
                intputChar = Convert.ToChar(Console.ReadLine());
                intputChar = Char.ToUpper(intputChar); //If the user enter a lower letter, we will convert it on a capital letter.

                //Check if the user Intput are in the word or not.
                bool wrong = true;
                for (int i = 0; i < wordClear.Length; i++)
                {
                    if (intputChar == wordClear[i])
                    {
                        wrong = false;

                        if (selectedWordIncognit[i] == lowBar)
                        {
                            selectedWordIncognit[i] = wordClear[i];
                        }
                        else
                        {
                            guessed--; //If the user enter a guessed letter, the scoreboard will not update.
                        }

                        //To check if all the character are guessed or not, and exit the round if the user win.
                        string incognit = string.Join(" ", selectedWordIncognit);
                        string word = string.Join (" ", wordClear);
                        if (incognit == word)
                        {
                            exitGame = true;
                        }
                    }
                }

                //To have the scoreboard updated
                if(wrong)
                {
                    attempts--;

                    //Mark with '-', on the alphabet the letter that has already been entered. AND IS WRONG
                    for (int j = 0; j < charArrayAlphabet.Length; j++)
                    {
                        if (intputChar == charArrayAlphabet[j])
                        {
                            charArrayAlphabet[j] = centerBar;
                        }
                    }
                }
                else
                {
                    guessed++;

                    //Mark with '_', on the alphabet the letter that has already been entered. AND IS NOT WRONG
                    for (int j = 0; j < charArrayAlphabet.Length; j++)
                    {
                        if (intputChar == charArrayAlphabet[j])
                        {
                            charArrayAlphabet[j] = lowBar;
                        }
                    }
                }

                //Replace the draw if user enter a wrong letter.
                if (attempts < 7)
                {
                    charMatrixDraw[1, 7] = '|';
                }
                if (attempts < 6)
                {
                    charMatrixDraw[2, 7] = 'O';
                }
                if (attempts < 5)
                {
                    charMatrixDraw[3, 7] = '|';
                }
                if (attempts < 4)
                {
                    charMatrixDraw[3, 6] = '/';
                }
                if (attempts < 3)
                {
                    charMatrixDraw[3, 8] = '\\';
                }
                if (attempts < 2)
                {
                    charMatrixDraw[4, 6] = '/';
                }
                if (attempts < 1)
                {
                    charMatrixDraw[4, 8] = '\\';
                }

                Console.Clear();

            } while (!exitGame && attempts > 0);

            //Show the number of attempts that we have and the guessed character.
            Console.WriteLine(msgYourAttempts + " " + attempts);
            Console.WriteLine(msgYourGuessed + " " + guessed + "\n");

            //Show the final draw.
            Console.ForegroundColor = ConsoleColor.Cyan;
            for (int i = 0; i < charMatrixDraw.GetLength(0); i++)
            {
                for (int j = 0; j < charMatrixDraw.GetLength(1); j++)
                {
                    Console.Write(charMatrixDraw[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.ResetColor();


            //Show to player the final message.
            Console.ForegroundColor = ConsoleColor.White;
            if (attempts == 0)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine(msgLose + "\n");
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine(msgWin + "\n");
            }
            Console.ResetColor();
            Console.WriteLine($"{msgWordReveal} {selectedWord}");
        }
    }
}