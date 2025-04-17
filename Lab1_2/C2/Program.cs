/*Bài 2: Viết chương trình nhập vào mảng gồm n phần tử nhập từ bàn phím. Viết hàm để kiểm
tra xem một số có phải là số nguyên tố hay không, hiển thị chỉ số và giá trị của những phần tử
là số nguyên tố trong mảng.*/
bool LaSoNguyenTo(int n)
{
    if (n < 2) return false;
    for (int i = 2; i <= Math.Sqrt(n); i++)
        if (n % i == 0) return false;
    return true;
}

void HienThiSoNguyenToTrongMang(int[] arr)
{
    Console.WriteLine("Các phần tử là số nguyên tố trong mảng:");
    for (int i = 0; i < arr.Length; i++)
    {
        if (LaSoNguyenTo(arr[i]))
        {
            Console.WriteLine($"Vị trí {i} → Giá trị: {arr[i]}");
        }
    }
}

