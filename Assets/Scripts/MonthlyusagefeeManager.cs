using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MonthlyusagefeeManager : ViewManager
{
    [SerializeField] InputField spendingInputField;
    [SerializeField] InputField incomeInputField;
    [SerializeField] InputField savingInputField;
    [SerializeField] InputField outMoneyInputField;

    public delegate void AddHouseKeepingBook(HouseKeepingBook houseKeeping);
    public AddHouseKeepingBook addHouseKeepingBookCallBack;

    public void OnClickMonthlyusagFee()
    {
        string spending = spendingInputField.text;
        string income = incomeInputField.text;
        string saving = savingInputField.text;
        string outMoney = outMoneyInputField.text;

        bool isValid = true;

       
        //if (isValid)
        //{
        //    HouseKeepingBook houseKeepingBook;

            //houseKeepingBook.spendig = spending;
            //houseKeepingBook.income = income;
            //houseKeepingBook.saving = saving;
            //houseKeepingBook.outMoney = outMoney;

        //    addHouseKeepingBookCallBack(houseKeepingBook);
        //    OnClickClose();
        //}
    }
        public void OnClickClose()
        {
            OnClickClose();
        }
    
}

