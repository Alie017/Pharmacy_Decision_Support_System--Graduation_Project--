import React from 'react'

const Prices = () => {
  return (
		<div className='prices'>
			<p className='title'>
				Reçete Tutarları(İlaç katılım payı elden tahsil edilecek)
			</p>
			<div className='prices-table'>
				<div className='price-col'>
					<div className='price-cell'>
						<span>%8 KDV</span>
						<span className='value'>: 0.23</span>
					</div>
					<div className='price-cell'>
						<span>%18 KDV</span>
						<span className='value'>: 0.00</span>
					</div>
					<div className='price-cell'>
						<span>Fiyat Farkı</span>
						<span className='value'>: 0.00</span>
					</div>
				</div>
				<div className='price-col'>
					<div className='price-cell'>
						<span>İlaç Kat Payı Tutarı</span>
						<span className='value'>: 0.79</span>
					</div>
					<div className='price-cell'>
						<span>Ecz. İndirim Tutarı</span>
						<span className='value'>: 0.00</span>
					</div>
					<div className='price-cell'>
						<span>Toplam Tutar</span>
						<span className='value'>: 3.94</span>
					</div>
				</div>
				<div className='price-col'>
					<div className='price-cell'>
						<span>Muayaene Kat. Payı (elden)</span>
						<span className='value'>: 3.60</span>
					</div>
					<div className='price-cell'>
						<span>Muayaene Kat. Payı (maaştan)</span>
						<span className='value'>: 0.00</span>
					</div>
					<div className='price-cell'>
						<span>Ödenecek Tutar</span>
						<span className='value'>: 3.15</span>
					</div>
				</div>
			</div>
		</div>
	)
}

export default Prices
