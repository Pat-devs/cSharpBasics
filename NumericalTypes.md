# Integer types
| Name   | Bytes | Allow Negatives | Minimum                    | Maximum                    |
|--------|-------|-----------------|----------------------------|----------------------------|
| sbyte  | 1     | Yes             | -128                       | 127                        |
| short  | 2     | Yes             | -32,768                    | 32,767                     |
| int    | 4     | Yes             | -2,147,483,648             | 2,147,483,647              |
| long   | 8     | Yes             | -9,223,372,036,854,775,808 | 9,223,372,036,854,775,807  |
| byte   | 1     | No              | 0                          | 255                        |
| ushort | 2     | No              | 0                          | 65,535                     |
| uint   | 4     | No              | 0                          | 4,294,967,295              |
| ulong  | 8     | No              | 0                          | 18,446,744,073,709,551,615 |

# Decimal / floating point types
| Type  | Bytes | Range | Digits of Precision | Hardware Supported |
|-------|-------|-------|---------------------|--------------------|
|float  |   4   |-------|         7           |        Yes         |
|double |   8   |-------|     15-16           |        Yes         |
|decimal|  16   |-------|     28-29           |        No          |