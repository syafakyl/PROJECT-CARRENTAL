<%@ Page Title="" Language="C#" MasterPageFile="~/MasterUser.Master" AutoEventWireup="true" CodeBehind="User.aspx.cs" Inherits="PROJECT_ASP.NET.User" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .masthead {
  background-image: url("/App_Themes/Theme1/assets/bg/scbd.jpeg");
}

        .card-body {
  width: 100%;
  height: 100%;
  top: 0;
  right: -100%;
  position: absolute;
  background: rgba(0, 0, 0, 0.2);
  border-radius: 16px;
  box-shadow: 0 4px 30px rgba(0, 0, 0, 0.1);
  backdrop-filter: blur(10px);
  -webkit-backdrop-filter: blur(5px);
  border: 1px solid rgba(0, 0, 0, 0.3);
  color: #fff;
  padding: 30px;
  display: flex;
  flex-direction: column;
  transition: 0.5s ease;
}
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <!-- Masthead-->
        <header class="masthead">
            <div class="container px-4 px-lg-5 d-flex h-100 align-items-center justify-content-center">
                <div class="d-flex justify-content-center">
                    <div class="text-center">
                        <h1 class="mx-auto my-0 text-uppercase">Car Bay</h1>
                        <h2 class="text-white-50 mx-auto mt-2 mb-5">Rental Car Website</h2>
                        <a class="btn btn-primary" href="#card-sec">Rent Car</a>
                    </div>
                </div>
            </div>
        </header>
        <!-- About-->
        <section class="about-section text-center" id="about">
            <div class="container px-4 px-lg-5">
                <div class="row gx-4 gx-lg-5 justify-content-center">
                    <div class="col-lg-8">
                        <h2 class="text-white mb-4">Why Choose Us?</h2>
                        <p class="text-white-50">
                          Choose our car rental service for a seamless and satisfying experience. With a wide selection of vehicles to fit every need and budget, flexible rental options, friendly customer service, a commitment to safety, and competitive pricing with no hidden fees, we ensure that every journey with us is smooth, comfortable, and worry-free.
                        </p>
                    </div>
                </div>
                <img class="img-fluid" src="App_Themes/Theme1/assets/bg/MIT-First-Gen-Students-02-PRESS.jpg" alt="..." />
            </div>
            <br>
            <br>
        </section>
        <!-- Projects-->
        <section id="card-sec" class="p-5">
          <h2 class="mt-5">Rental Cars</h2>
            
            <div class="card-row">
            
              <div class="card mt-3">
              <img src="App_Themes/Theme1/assets/car/avanza.png" class="card-img" alt="">
                <div class="card-body">
                  <h1 class="card-title">Avanza</h1>
                  <p class="card-sub-title">TOYOTA</p>
                  <p class="card-info">Avanza adalah mobil MPV yang diproduksi oleh Toyota. Dirancang untuk keluarga, Avanza menawarkan ruang yang luas dan efisiensi bahan bakar yang baik, membuatnya populer di banyak pasar di seluruh dunia.</p>
                    <a class="btn btn-primary" href="Avanza.aspx">Rent</a>
                </div>
              </div>
            
                <div class="card mt-3">
                <img src="App_Themes/Theme1/assets/car/innova.png" class="card-img" alt="">
                <div class="card-body">
                  <h1 class="card-title">Innova</h1>
                  <p class="card-sub-title">TOYOTA</p>
                  <p class="card-info">Innova juga diproduksi oleh Toyota dan juga merupakan MPV yang dirancang untuk keluarga. Ini menonjol karena kenyamanan dalam perjalanan jarak jauh, desain yang fleksibel, dan performa yang handal.</p>
                    <a class="btn btn-primary" href="Innova.aspx">Rent</a>
                </div>
              </div>
        
                <div class="card mt-3">
                <img src="App_Themes/Theme1/assets/car/fortuner.png" class="card-img" alt="">
                <div class="card-body">
                  <h1 class="card-title">Fortuner</h1>
                  <p class="card-sub-title">TOYOTA</p>
                  <p class="card-info">Fortuner adalah SUV tangguh yang diproduksi oleh Toyota. Dirancang untuk menghadapi kondisi jalan yang ekstrem, Fortuner menawarkan daya tahan yang diinginkan oleh pengemudi yang suka menjelajah.</p>
                    <a class="btn btn-primary" href="Fortuner.aspx">Rent</a>
                </div>
              </div>
        
            </div>
        
              <div class="card-row">
        
          <div class="card mt-3">
          <img src="App_Themes/Theme1/assets/car/civic.png" class="card-img" alt="">
            <div class="card-body">
              <h1 class="card-title">Civic</h1>
              <p class="card-sub-title">HONDA</p>
              <p class="card-info">Civic adalah sedan yang diproduksi oleh Honda. Dikenal karena gaya sporty-nya, performa yang responsif, dan teknologi canggih, Civic menjadi salah satu mobil paling populer selama beberapa dekade.</p>
                    <a class="btn btn-primary" href="Civic.aspx">Rent</a>
            </div>
          </div>
        
            <div class="card mt-3">
            <img src="App_Themes/Theme1/assets/car/hrv.png" class="card-img" alt="">
            <div class="card-body">
              <h1 class="card-title">HRV</h1>
              <p class="card-sub-title">HONDA</p>
              <p class="card-info">HRV adalah SUV crossover yang diproduksi oleh Honda. Menggabungkan gaya SUV dengan kenyamanan mobil penumpang, HRV menawarkan kinerja yang solid, ruang kargo yang luas, dan fitur keselamatan canggih.</p>
                    <a class="btn btn-primary" href="HRV.aspx">Rent</a>
            </div>
          </div>
        
            <div class="card mt-3">
            <img src="App_Themes/Theme1/assets/car/brio.png" class="card-img" alt="">
            <div class="card-body">
              <h1 class="card-title">Brio</h1>
              <p class="card-sub-title">HONDA</p>
              <p class="card-info">Brio adalah mobil hatchback yang juga diproduksi oleh Honda. Dirancang untuk mobilitas perkotaan, Brio menawarkan ukuran yang kompak, manuverabilitas yang baik, dan efisiensi bahan bakar yang cukup.</p>                    <a class="btn btn-primary" href="Brio.aspx">Rent</a>
            </div>
          </div>
        
        </div>
          
        </section>    
        
        <!-- Contact-->
        
    <section id="contact" class="p-5">
        <div class="container-fluid text-center mb-3">
          <div class="row">
            <div class="col-12">
              <h2 class="mt-5">Contact <span>us</span></h2>
            </div>
          </div>
        </div>
        <div class="container-fluid trans-bg-low">
          <div class="row p-3">
            <div class="col-12 col-lg-6  ">
              <iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d31556.3698869875!2d115.11941641853436!3d-8.639484521210957!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x2dd23861f4589665%3A0x5030bfbca82fd30!2sCanggu%2C%20Kec.%20Kuta%20Utara%2C%20Kabupaten%20Badung%2C%20Bali!5e0!3m2!1sid!2sid!4v1688746562997!5m2!1sid!2sid"  allowfullscreen=""  loading="lazy"  referrerpolicy="no-referrer-when-downgrade"  class="map "></iframe>
            </div>
            <div class="col-12 col-lg-6">
  
              <form4 class="mt-3 mt-lg-0" id="myForm" action="https://formspree.io/f/mrgnbvwn" method="POST">
                <div class="mb-3 fs-4  trans-bg-low p-2">
                  <label for="exampleInputEmail1" class="form-label" >Email address</label>
                  <input  type="email" name="email" class="form-control fs-5"  id="exampleInputEmail1" aria-describedby="emailHelp" placeholder="your@email.com"/>
                  <div id="emailHelp" class="form-text">
                    We'll never share your email with anyone else.
                  </div>
                </div>
  
                <div class="mb-3 fs-4 trans-bg-low p-2">
                  <label for="exampleFormControlTextarea1" class="form-label">Critics and suggestions</label>
                  <textarea  class="form-control fs-5" name="message" id="exampleFormControlTextarea1" rows="10" placeholder="Your message"></textarea>
                </div>
                <button type="submit" class="btn btn-primary" runat="server">Submit</button>
              </form4>
  
            </div>
          </div>
        </div>
      </section>
</asp:Content>
