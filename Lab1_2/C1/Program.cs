/*Bài 1: Viết một hàm để tính tổng của tất cả các số chẵn trong một mảng*/
int TinhTongChan(int[] arr)
{
    int tong = 0;
    foreach (int x in arr)
    {
        if (x % 2 == 0)
            tong += x;
    }
    return tong;
}
