# Ant Colony System

This is a simple console implementation of the Ant Colony System algorithm by Dorigo & Gambardella as described in: *Dorigo, Marco, and Luca Maria Gambardella. "Ant colony system: a cooperative learning approach to the traveling salesman problem." IEEE Transactions on evolutionary computation 1.1 (1997): 53-66.*

It is written in **C# (build with .NET Core 2.0)**

# Running
Create TSP directory inside project folder and put there some `.tsp` file from TSPLIB repository.

By default it tries to load `kroA100.tsp` file. You can change load path in `Program.cs` file.

# Parameters
Default parameters (file `Parameters.cs`):
* Beta = 2
* Global Pheromone Evaporation Rate = 0.1
* Local Pheromone Evaporation Rate = 0.01
* Q0 = 0.9
* Ant Count = 20
* Iterations = 10000

# License

MIT License

Copyright (c) 2018 mbalchanowski

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
