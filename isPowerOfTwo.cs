boolean isPowerOfTwo2(long n) {

return (n != 0) && ((n & (n - 1)) == 0);

}
