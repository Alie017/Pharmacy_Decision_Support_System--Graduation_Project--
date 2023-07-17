import React, { useState } from 'react'
import { useNavigate } from 'react-router-dom'
import '../../medulla.css'

const CreatePrescription = () => {
  const navigate = useNavigate()

	const [tc, setTc] = useState('')

	const [prescription, setPrescription] = useState('')

	const handleRedirect = () => {
		navigate(`/medulla/result/${tc}/${prescription}`)
	}
	
	return (
		<div className='medulla'>
			<p className='title'>E-Reçete Sorgu</p>
			<div className='p-10'>
				<p className='title pb-0 mb-0'>Sorgulama</p>
				<div className='create-prescription'>
					<div className='row'>
						<div className='text'>
							<p>T.C. Kimlik No</p> <span>:</span>
						</div>
						<input
							type='text'
							onChange={e => setTc(e.target.value)}
							value={tc}
						/>
						<div className='operation'>
							<p className='text-danger'>
								(F3 Tuşu ile TC Kimlik No Bilgisini Getirebilirsiniz.)
							</p>
						</div>
					</div>
					<div className='row'>
						<div className='text'>
							<p>E-Reçete No</p> <span>:</span>
						</div>
						<input
							type='text'
							onChange={e => setPrescription(e.target.value)}
							value={prescription}
						/>
						<div className='operation'>
							<button onClick={handleRedirect}>Sorgula</button>
						</div>
					</div>
					<div className='row'>
						<div className='text'>
							<p>Takip No</p> <span>:</span>
						</div>
						<input type='text' />
						<div className='operation'>
							<button>Sorgula</button>
						</div>
					</div>
					<div className='row'>
						<div className='text'>
							<p>Reçete Tarihi</p> <span>:</span>
						</div>
						<input type='date' />
						<div className='operation'>
							<button>SMS olarak gönder</button>
						</div>
					</div>
				</div>
			</div>
		</div>
	)
}

export default CreatePrescription
