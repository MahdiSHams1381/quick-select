<div>
الگوریتم انتخاب سریع : می تواند با سرعت بهینه شده kامین کوچکترین مقدار را از درون ارایه پیدا کند 
<br> T(n)={O(n)+T(n-1)}
<br> o(n2)

شبه کد : 
<br>function quickSelect(list, left, right, k)

   <br>if left = right
      <br>return list[left]

   <br>Select a pivotIndex between left and right

  <br> pivotIndex := partition(list, left, right, 
  <br>                                pivotIndex)
  <br> if k = pivotIndex
  <br>    return list[k]
  <br> else if k < pivotIndex
  <br>    right := pivotIndex - 1
 <br>  else
  <br>    left := pivotIndex + 1 
</div>