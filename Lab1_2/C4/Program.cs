/*Bài 4: Viết hàm để tìm số lớn thứ hai trong một mảng các số nguyên.
*/
int TimSoLonThuHai(int[] arr)
{
    int max1 = int.MinValue, max2 = int.MinValue;

    foreach (int x in arr)
    {
        if (x > max1)
        {
            max2 = max1;
            max1 = x;
        }
        else if (x > max2 && x != max1)
        {
            max2 = x;
        }
    }

    if (max2 == int.MinValue)
        throw new Exception("Không tìm được số lớn thứ hai!");

    return max2;
}
