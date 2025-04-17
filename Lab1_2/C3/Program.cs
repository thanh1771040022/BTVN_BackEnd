/*Bài 3: Viết một hàm để đếm số lượng số âm và số dương trong một mảng gồm n phần tử nhập
từ bàn phím.

 */
void DemSoAmVaDuong(double[] arr, out int demAm, out int demDuong)
{
    demAm = demDuong = 0;
    foreach (double x in arr)
    {
        if (x < 0)
            demAm++;
        else if (x > 0)
            demDuong++;
    }
}
