import React from 'react'

const DrugList = ({ drugs }) => {
	const date = new Date()

	return (
		<div className='drug-list'>
			<p>İlaç Listesi</p>
			<table className='table'>
				<thead>
					<tr>
						<th>Barkod</th>
						<th>Adı</th>
						<th>Adet</th>
						<th>Kullanım</th>
						<th>Tutar</th>
						<th>Fark</th>
						<th>Rapor</th>
						<th>Bitiş Tarihi</th>
						<th>Mesaj</th>
					</tr>
				</thead>
				<tbody>
					{drugs.map(drug => (
						<tr key={drug.barcode}>
							<td>{drug.barcode}</td>
							<td>{drug.name}</td>
							<td>{Math.ceil(Math.random() * 3)}</td>
							<td>1 x 1 (1 Gün)</td>
							<td>{(Math.random() * 50).toFixed(2)}</td>
							<td>0.00</td>
							<td></td>
							<td>{`${date.getDay() + 10}/${date.getMonth() + 2}/${date.getFullYear()}`}</td>
							<td>yok</td>
						</tr>
					))}
				</tbody>
			</table>
		</div>
	)
}

export default DrugList
