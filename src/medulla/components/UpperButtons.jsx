import React from 'react'
import { useNavigate } from 'react-router-dom'

const UpperButtons = ({ prescription }) => {
	const navigate = useNavigate()

	return (
		<div className='upper-buttons'>
			<button onClick={e => navigate('/medulla')}>Geri Dön</button>
			<button onClick={e => e.preventDefault()}>Ana Sayfa</button>
			<button onClick={e => e.preventDefault()}>İlaç Listesi</button>
			<button onClick={e => e.preventDefault()}>Rapor Görme/Kaydet</button>
			Reçete No :{' '}
			<a href='' onClick={e => e.preventDefault()}>
				{prescription}
			</a>{' '}
			|
		</div>
	)
}

export default UpperButtons
