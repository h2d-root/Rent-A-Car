using Busines.concrate;
using DataAccess.Concrate.EntitiyFramework;

//CarTest();

//ColorTest();

CarDetailDtoTest();

static CarManager CarTest()
{
    CarManager carManager = new CarManager(new EFCarDal());
    foreach (var item in carManager.GetAll())
    {
        Console.WriteLine("Car ID : {0} - Color ID : {1} - Model Year : {2} - Daily Price : {3}", item.CarId, item.ColorId, item.ModelYear, item.DailyPrice);
    }

    return carManager;
}

static void ColorTest()
{
    ColorManager colorManager = new ColorManager(new EFColorDal());
    foreach (var colorItem in colorManager.GetAll())
    {
        Console.WriteLine("Color ID : {0} - Color Name : {1}", colorItem.ColorId, colorItem.ColorName);
    }
}

static void CarDetailDtoTest()
{
    CarManager carDetailManager = new CarManager(new EFCarDal());
    foreach (var carDetail in carDetailManager.GetCarDetail())
    {
        Console.WriteLine("Brand Name : {0} \nModel Year : {1} \nColor : {2} \nDaily Price : {3} \n" +
            "-------------------------------------------------" +
            "", carDetail.BrandName, carDetail.ModelYear, carDetail.ColorName, carDetail.DailyPrice);
    }
}