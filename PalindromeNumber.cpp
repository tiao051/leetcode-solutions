class Solution {
public:
    bool isPalindrome(int x) {
        if (x < 0 || x % 10 == 0 && x != 0){
            return false;
        }

        int reverseHalf = 0;
        while (x > reverseHalf)
        {   
            int lastDigit = x % 10;
            reverseHalf = reverseHalf * 10 + lastDigit;
            x /= 10;
        }
        
        return x == reverseHalf || x == reverseHalf / 10;
    }
};