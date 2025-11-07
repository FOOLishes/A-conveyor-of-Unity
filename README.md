# A-conveyor-of-Unity
It's a small project of a NEW Unity and C# learner.

# Project Introduction
## This project is an automatic detection and alarm system for conveyor belts based on Unity, which has achieved:
-Automatically generate a Box and send it

-Real-time counting

-No material alarm (material cut-off)

-Blockage alarm (jammed box)

-Dynamic UI Chinese display (supports importing Chinese fonts)

# Code section
| section | Function Description |
|------|-----------|
| `BoxSpawner.cs` | It can automatically generate Box in designated location |
| `Conveyor.cs` | Simulate the continuous movement of the conveyor belt |
| `BoxDetector plus.cs` | detect the Blockage and No matrial |
| `BoxCounter.cs` | Count the number of Box that pass through and update UI |

## Core logic
1. **Material cut-off Detection**： If no new Box enters the detection area within the 'noBoxTimeout' seconds, an alarm will be triggered;
2. **Blockage Detection**：If the same Box stays in the detection area for more than 'JamTime' , it is determined to be stuck；
3. **Status Synchronization**：'BoxDetector plus' will call the 'Addcount()' of 'BoxCountr' to count and update UI；
4. **UI Display**：Display the number by TextMeshProUGUI。

## Next plan
- [ ] Add the alarm by UI.
- [ ] Add some voice.
- [ ] Make the alarm be trigger once not keep.

##  Author
 **Foolist** 
 
 Project Learning Record Plan:learning Unity and C# to improve myself , and make some English friend.
 
 2025.11
