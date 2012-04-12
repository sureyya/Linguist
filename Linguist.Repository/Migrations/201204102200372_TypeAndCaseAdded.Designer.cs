// <auto-generated />
namespace Linguist.Repository.Migrations
{
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Migrations.Infrastructure;
    
    public sealed partial class TypeAndCaseAdded : IMigrationMetadata
    {
        string IMigrationMetadata.Id
        {
            get { return "201204102200372_TypeAndCaseAdded"; }
        }
        
        string IMigrationMetadata.Source
        {
            get { return null; }
        }
        
        string IMigrationMetadata.Target
        {
            get { return "H4sIAAAAAAAEAOy9B2AcSZYlJi9tynt/SvVK1+B0oQiAYBMk2JBAEOzBiM3mkuwdaUcjKasqgcplVmVdZhZAzO2dvPfee++999577733ujudTif33/8/XGZkAWz2zkrayZ4hgKrIHz9+fB8/Iv7Hv/cffPx7vFuU6WVeN0W1/Oyj3fHOR2m+nFazYnnx2Ufr9nz74KPf4+g3Th6fzhbv0p807fbQjt5cNp99NG/b1aO7d5vpPF9kzXhRTOuqqc7b8bRa3M1m1d29nZ2Du7s7d3MC8RHBStPHr9bLtljk/Af9eVItp/mqXWflF9UsLxv9nL55zVDTF9kib1bZNP/so+eE2bpo2vGrfFU1RVvV1+OTqs4/So/LIiN8Xufl+Xsit/MQyH1ku6WOTwnB9vrN9Srnzj/76Lhui2mZ+42o2e+VXwcf0Ecv62qV1+31q/xcXz2bfZTeDd+7233Rvua9g94/++jzdUG/v1iXZTYp6e/zrGxotKtPH72mweef58u8ztp89jJr27xe4tWckVciPFp9ejs6PLy7swc63M2Wy6rNWprpHt4dLN8ULZFEEX3d1jQ3H6XPinf57Hm+vGjnFtsvsnfmE/r1o/SrZUFMRi+19Tr3Ryd/b+71ad5M62IlCP6w+yZSn9Q5CG76xkdviJtvBPUiuywumK4doK9pwkjq8uaj9FVecotmXqyEl8fKeb+/1+pZXS1eVeio9+Xv/7pa11NMSjXU4k1WX+RtiN7ju47jN8qBAfMjQfCx/LKe5bVB9GzZ3tuLYPpzwFnfrepZnKvMPP7+2sSxVPhNj586X38QMwHEjxjpG2akN/m79v8fevFNnS0b5dwoE4N/fv+wlePj3pc9Vu63+CBu9iD9iKmDeSQMf+gceZI1PwedVlCO/x8Sv1szN4D4DJ4+IfrqKCGKwXdBD8dNU00L/sZT+6HYhoM7Xc7SG2XYdc1WJP1iXbbFqiymhPdnH+2Mx7s9om2CayR/aEgh+G91"
                       + "qegNcvPYO3Z3CMEhI+yws47Y+418wHzfQM6vP96+9zqE2QZX1iFnwrD3G/SwD3wLgt527CIy0ABZQcpWx2/iVdYMZJi7KOKd13kbUovsmBPA7sh7owxBeGFCD4Yb4g1A1CnsARDeuOHl0CD3YAxqipB/QmQ6Vt5rN+gKdC3ubbSKHYolQYjgLZWIBybEu2vfw/HeghZdt71PiE0K5jYqxsPdY6UNZBjQKDeR8msMPhIJ98d/g8K5pcrxsHcyuYEIwxrmNvTcQAtjoK1esd89vivZMf3g8d2BNNrjL7LVirSQl1bTT9LXklM72X79/hmzhcC4Ow0I3NWCtidyQrOLvPMtHKZZ/qyom5bclWzCLtvJbNFrdkstanrrKNP+tBmVZF7A76G+7uYXrf7tAHPUfEYDXNAM81h1pD4D9d9MkeDMyqyOePUnVbleLIcig01vv5GknA9AP7o9jCDF5kMKvngPeL5/GsDzv+jDe3y3Q9zuVHruq7bsCFaXN27FOZt0x9dgnXjOjOHdxDvDr34w80QnSvMP/hTpR/+/newhO/k1Jrqfz2JYN01y/LX/906wZJgCBcOf3B7C/8dY5Aa/cphTzhr8/uX51iDLeKDvfA3WGcw56fs/Cxwk2Zxg9vmT20OQ1IwPQT55DwgmzxIAMR/eHs7PFR9+XQXTzcL8v41haApmBUf/P5mV6zySNgqIXMCZWBTLjJD8fxOZ/z9F4q9N3g8m703aNAxq+la3E9TfYmIib70H9RGvRRbIoqmA/rTfatoYXmzuQCvb+dfBS+PJr4nXe6Pk2OysgRDbvPUtRtsNZ9+bObpZjltwRveV2/hYEbrHkyJfk+gW2HtT/0bE/t/IDRuG+8EcEUn93IIpIm/dNsCKTMFgtuhrzoKB996zcRvU/t/IIMMDvpk/enmwbhNrzPQT+7fNg2kO6gs/OcYEQaqLCdFoPqyblJImH6U0+stihoTU6+umzRdjNBi//kXlSVmw52kafJEt"
                       + "i/O8ad9Ub3NKTCJnRrnKssgayVK+V7rNrrg2zayMJNsgCCEfdPJjP4Tl5/Wy+EXrnIZOGJ0XCCdvXHburVV3eu+GHZLDku6Wl1k9nWf11iJ7d+e9F0v9HNY3Aa+/+DqjP9riG1t8jSup/3/Mq2YfpLsCQvSeAL42+fugfAU1NP5vZEL73siPJlOknBNJP5dC2QcV+DU/q2wxGLv8/4M7JE/0DUyupIu+CUAmZfQNwPoGOa6TGAmR+yj9Inv3PF9etPPPPtrdO3jvaZCo7RvmZc9/G/JJe6t2ncVTg5C/jEuDXZdtsSqLKXX62Uc74/Fub3z9tegAlPswhPWtHiASpbwGHbKSOKNpa/I0e0mRl3WxnBarrOxg32l3SwkFRS3E7jdP81W+xMR0h3ebvjaHFxZ0R1/cRILAU9/MAJ2Q/BuZsxvmn+2qD0c++FmZ9/eajA+c+IGFpX4/N6QcLNyfvVnvp+g+aLJumPAg+emBCj7/WZn+W0/JB0795lx0v7sNGUgL+puafTEFNiS3RrUTPvc4QLMvoaL6KHWWpWsEJAAngzqpaJrFNumXTYQ7QvhOl/Q6cF/FevDSRjd0IZzbAy8fx0BrlvIGsAEX96AH38Y6CRPlnb7ChMugzU69duGsDBn2QD47c8spN/tZj0NjRsF70X3Y9XLDwdxioB3bFBnlJuv19VGNKEDvLfnggwcXWSXpj+8GPf3+iA7rZe/F4PNbD7SX/LPfPb4rjK8f0J+9JB/pt/USXrj8Rdmf4sKBQOZymU8DzWbbnC3PK6NhOxiZJh3f+ou8zcjrz8Dj59m0pa9JQBpKQ35k1utOF5N8drb8ct2u1i0NOV9MymufGFDUm/p/fLeH8+MvOZ3lZTW//hAIzQKBy5fLJ+uinFm8n/VjiyEQsAAaN2IuW8SPF9cW0otqeUtASr6nxnC9yRcr4p68+XL5OrvMh3G7mYYhxR4/LbKLOls0CsO9T38S+80W747+nwAAAP//LDja"
                       + "ZzA9AAA="; }
        }
    }
}
