@echo off
echo ----HACKER VIRUS----
echo MADE BY THE ARCHER HACKERS!
echo THIS VIRUS WILL HACK YOUR COMPUTER
echo ----RULES----
echo DO NOT SHARE TO ANYBODY ELSE.
echo IF YOU DO THIS YOU WILL FACE A CONSEQUENCE.
echo EXIT THIS VIRUS IF YOU DON'T WANT YOUR
echo ACCOUNT TO BE HACKED, ALSO YOUR COMPUTER TOO!
pause
cls
echo Accessing users...
echo Connecting to Command and Control server...
echo IP address found!
echo Sending info to a text file to desktop: desk-ahack23...
echo Info:sender(done=true)
echo %username%, (: 
echo You shouldnt've run this virus, kid...
echo cause things are bout' to get a whole lot worse...
pause
cls
echo We have access to everything you own,
echo We are going to delete this file, and leave you a note (:
echo say the last words to you, yes you %username%,
echo because, %username% you are completely hacked and you will be kept in our so-called "victims lair"...
mkdir %userprofile%\Desktop\ARCHERHACKERSDATA
echo You are our next target, %username%... because you will never get your computer and accounts back... and we will do something bad to both of those things so be ready for your work to all be gone... archer hackers are happy! (:... and also we will say something to you, %username%... you know you have been hacked by Archer Hackers right? well you need to contribute to our team or else we will use your location for fun... (: so do it quick! > %userprofile%\desktop\ARCHERHACKERSDATA\note.txt
echo We will meet you soon, in 10 minutes, %username%... so always contribute to the Archer Hackers team fast, but here is a quick note: You will be a never forgotten victim of ours... > %userprofile%\desktop\ARCHERHACKERSDATA\remembertokeep.txt
echo Heres the link to contribute: https://ahakers.com/contrib/victim > %userprofile%\desktop\ARCHERHACKERSDATA\contrib.txt
copy %userprofile%\desktop\creepy.bat C:\Windows\Temp
del %userprofile%\desktop\creepy.bat
exit
