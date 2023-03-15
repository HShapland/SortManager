# SortManager
```
             
  /$$$$$$                                                /$$$$$$                        /$$                        
 /$$__  $$                                              /$$__  $$                      | $$                        
| $$  \ $$  /$$$$$$   /$$$$$$  /$$$$$$  /$$   /$$      | $$  \__/  /$$$$$$   /$$$$$$  /$$$$$$    /$$$$$$   /$$$$$$ 
| $$$$$$$$ /$$__  $$ /$$__  $$|____  $$| $$  | $$      |  $$$$$$  /$$__  $$ /$$__  $$|_  $$_/   /$$__  $$ /$$__  $$
| $$__  $$| $$  \__/| $$  \__/ /$$$$$$$| $$  | $$       \____  $$| $$  \ $$| $$  \__/  | $$    | $$$$$$$$| $$  \__/
| $$  | $$| $$      | $$      /$$__  $$| $$  | $$       /$$  \ $$| $$  | $$| $$        | $$ /$$| $$_____/| $$      
| $$  | $$| $$      | $$     |  $$$$$$$|  $$$$$$$      |  $$$$$$/|  $$$$$$/| $$        |  $$$$/|  $$$$$$$| $$      
|__/  |__/|__/      |__/      \_______/ \____  $$       \______/  \______/ |__/         \___/   \_______/|__/      
                                        /$$  | $$                                                                  
                                       |  $$$$$$/                                                                  
                                        \______/   
```

This repo contains a console application that will sort a randomly generated array, using the chosen sort algorithm.

To use this repo run:
``` 
git clone https://github.com/HShapland/SortManager.git
```

To build and run the app:
```
cd ./SortManager/SortManager

dotnet build --configuration release ./SortManager.sln

cd SortManager/bin/Release/net6.0

.\SortManager.exe
```

The application will present you with a choice of sorting algorithms. Choose one by copying the name (no spaces) and choose the length of the array.
The app will then present you with a randomly generated array, a sorted array and the time taken.

### Credits
- [Mubashir Ahmad](https://github.com/Mubashir-A)
- [Byron Esson](https://github.com/byronEsson)
- [Luke Pinder](https://github.com/clear-dev)
- [Henry Shapland](https://github.com/HShapland/)
