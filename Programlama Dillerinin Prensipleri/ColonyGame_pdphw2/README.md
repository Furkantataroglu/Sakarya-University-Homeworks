# ColonyGame_pdphw2
PRINCIPLES OF PROGRAMMING LANGUAGES ASSIGNMENT 2

FURKAN TATAROĞLU

G201210089

REQUIREMENTS

We take numbers entered by the user as the populations of colonies, and we manage their food stocks and populations using a struct structure. Then, we make each colony fight each other once per turn. In these battles, populations and food stocks change. The last colony with either food stock or population remaining wins, and the program terminates.

LEARNINGS

We learned how to use the struct in C language to mimic the class structure found in object-oriented programming languages like Java and C++. We learned to use the abstract structure.

WHAT I DID IN THE ASSIGNMENT

Firstly, I created the abstract struct that we will use. This struct allows inheritance to the aTack and bTack structs. These attacks have their unique battle functions. aTack returns a random value between 0-1000, while bTack selects a value between 0-1000, doubles it, subtracts 500, and returns the result. In battles, colonies choose one of these attacks to fight with. An attack is not used by two colonies at the same time.

Then, I created the production functions. Using almost the same structure as the battle tactic, this time aUretim returns a value between 0-5, and bUretim returns a value between 5-10.

The colony structure holds populations, food stocks, counts of wins, and losses.

In the game structure, I obtained each colony's symbol using the getsymbols function with ASCII. After giving the initial values for the colonies in the first round, I took their food stocks as the square of their populations. Then, I displayed the initial values of the colonies on the screen. Lastly, I stopped the while loop when the population of a colony was reduced by one until the number of colonies was negative at the end of each round. At the start of each turn, I developed the function for increasing colony populations, producing and consuming food.

I then used two for loops to make each colony fight with each other once per turn. In the assignment, I wrote the required conditions for the battles in the functions.

The part I struggled with in the assignment was writing the functions for the battles. The code became a bit complex and hard to read, but it works properly.
