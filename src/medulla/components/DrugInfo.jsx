import React from 'react'

const DrugInfo = () => {
  return (
		<div className='drug-info'>
			<p className='title'>İlaç Bİlgileri</p>
			<div className='buttons'>
				<button onClick={e => e.preventDefault()}>Özel Durum</button>
				<button onClick={e => e.preventDefault()}>Eşdeğer</button>
				<button onClick={e => e.preventDefault()}>İlaç Bilgisi</button>
				<button onClick={e => e.preventDefault()}>Yeni</button>
				<button onClick={e => e.preventDefault()}>Rapor Seç</button>
				<button onClick={e => e.preventDefault()}>Ted.Şema</button>
				<button onClick={e => e.preventDefault()}>Maj.İlaç</button>
			</div>
		</div>
	)
}

export default DrugInfo
