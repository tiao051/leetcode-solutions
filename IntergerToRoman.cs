/// <summary>
/// Converts an integer to a Roman numeral representation.
/// 
/// Seven different symbols represent Roman numerals:
/// - I (1), V (5), X (10), L (50), C (100), D (500), M (1000)
/// 
/// Rules:
/// 1. If value doesn't start with 4 or 9, use the maximal symbol that can be subtracted,
///    append it, subtract its value, and convert the remainder.
/// 2. If value starts with 4 or 9, use subtractive form (IV, IX, XL, XC, CD, CM).
/// 3. Only powers of 10 (I, X, C, M) can appear consecutively up to 3 times.
///    V, L, D cannot repeat. Use subtractive form if you need 4 times.
/// 
/// Examples:
/// - 3749 → "MMMDCCXLIX" (3000 + 700 + 40 + 9)
/// - 58 → "LVIII" (50 + 8)
/// - 1994 → "MCMXCIV" (1000 + 900 + 90 + 4)
/// </summary>

public class Solution{
    public string IntToRoman(int num) {
        int[] values = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
        string[] symbols = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
        StringBuilder roman = new StringBuilder();

        for (int i = 0; i < values.Length; i++){ //1991 -> MCMXCI 1000 -> M (991) -> MCM (91) -> MCMXC (1) -> MCMXCI
            while (num >= values[i]){
                roman.Append(symbols[i]);
                num -= values[i];
            }
            if (num == 0){
                break;
            }
        }
        return roman.ToString();
    }
}